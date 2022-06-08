using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace PersonnelMgt
{
    public sealed class ConnDB
    {
        private static readonly ConnDB instance = new ConnDB();
        public static ConnDB Instance { get { return instance; } }
        static ConnDB() { }
        private ConnDB() { }
        
        string serverAddress;
        string serverPort;
        string authLogin;
        string authPass;
        string connString;
        string dbName = "personnel_mgt";

        //--------------------------------------------------------------
        // SetParams -- считывание данных из ini
        //--------------------------------------------------------------
        public void SetParams(string login, string pass)
        {
            IniSettings ini = new IniSettings();
            if (ini.KeyExists("DbName"))
                dbName = ini.Read("DbName");

            string serverAddressPort = "localhost:5432";
            if (ini.KeyExists("DbAddress"))
                serverAddressPort = ini.Read("DbAddress");

            this.authLogin = login;
            this.authPass = pass;
            SetServerAddress(serverAddressPort);
            UpdateConnString();
        }

        //--------------------------------------------------------------
        // UpdateConnString -- заполнение connection string
        //--------------------------------------------------------------
        private void UpdateConnString()
        {
            this.connString = String.Format(
                "Server={0}; Port={1}; User Id={2}; Password={3}; Database={4}; SSLMode=Prefer",
                serverAddress,
                serverPort,
                authLogin,
                authPass,
                dbName);
        }

        //--------------------------------------------------------------
        // SetServerAddress -- разбиение строки serverAddress на адрес и порт
        //--------------------------------------------------------------
        private void SetServerAddress(string address)
        {
            address = address.Trim();
            string port = "5432";       // по умолчанию
            int semicolonIndex = address.LastIndexOf(":");
            if (semicolonIndex != -1 && semicolonIndex < (address.Length - 1))
            {
                int portLength = address.Length - semicolonIndex - 1;
                port = address.Substring(semicolonIndex + 1, portLength);
                address = address.Substring(0, semicolonIndex);
            }
            this.serverAddress = address;
            this.serverPort = port;
        }

        //--------------------------------------------------------------
        // AttemptAuth -- проверка попытки авторизации
        //--------------------------------------------------------------
        public bool AttemptAuth()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);

            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
        }

        //--------------------------------------------------------------
        // SqlGetRows -- возвращает результат запроса SELECT как DataTable
        //
        // Принимает текст запроса, без параметров
        //--------------------------------------------------------------
        public DataTable SqlGetRows (string query)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    NpgsqlDataReader dataReader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    return dataTable;
                }
            }
            catch (Exception)
            {
                //TODO: написать throw npgsqlexception и успешно реагировать на него
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }

        //--------------------------------------------------------------
        // SqlGetRows_Parametrized -- возвращает результат запроса SELECT как DataTable
        //
        // Принимает текст запроса и список параметров
        //--------------------------------------------------------------
        public DataTable SqlGetRows_Parametrized(string query, List<CommonFuncs.SqlColumnAndParam> listParams = null)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;

                    // добавление параметров
                    if (listParams != null && listParams.Count > 0)
                        foreach (var tuple in listParams)
                            command.Parameters.Add(tuple.Parameter);

                    NpgsqlDataReader dataReader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    return dataTable;
                }
            }
            catch (Exception)
            {
                //TODO: написать throw npgsqlexception и успешно реагировать на него
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }

        //--------------------------------------------------------------
        // SqlGetRows_Implicit -- возвращает результат запроса SELECT как DataTable
        //
        // Принимает NpgsqlCommand с готовыми параметрами
        //--------------------------------------------------------------
        public DataTable SqlGetRows_Implicit(NpgsqlCommand command)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                command.Connection = conn;

                NpgsqlDataReader dataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                return dataTable;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }

        //--------------------------------------------------------------
        // SqlExecuteNonQuery -- выполняет SQL операцию и возвращает bool
        //
        // Принимает текст запроса, без параметров
        //--------------------------------------------------------------
        public bool SqlExecuteNonQuery(string text)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                using (var command = new NpgsqlCommand(text, conn))
                {
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
        }

        //--------------------------------------------------------------
        // SqlExecuteNonQuery_Consecutively -- выполняет SQL операцию и возвращает bool.
        // Выполняет все запросы подряд; откат всей транзакции при неудаче хотя бы одного.
        //
        // Принимает очередь запросов в виде списка [текст запроса, список параметров]
        //--------------------------------------------------------------
        public bool SqlExecuteNonQuery_Consecutively(List<CommonFuncs.SqlQueryAndParams> listQueriesQueue)
        {
            if (listQueriesQueue.Count == 0)
                return false;

            NpgsqlConnection conn = null;
            NpgsqlTransaction transaction = null;
            bool hasFailed = false;
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                using (transaction = conn.BeginTransaction())
                {
                    foreach (var queueItem in listQueriesQueue)
                    {
                        var command = new NpgsqlCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = queueItem.QueryText;
                        command.Connection = conn;
                        command.Transaction = transaction;

                        if (queueItem.ListParams.Count > 0)
                            foreach (var tuple in queueItem.ListParams)
                                command.Parameters.Add(tuple.Parameter);

                        using (command)
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows == 0)
                                hasFailed = true;
                        }
                    }

                    if (hasFailed)
                    {
                        transaction.Rollback();
                        return false;
                    }
                    else
                    {
                        transaction.Commit();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
        }

        //--------------------------------------------------------------
        // SqlExecuteNonQuery_Implicit -- выполняет SQL операцию и возвращает bool
        // Отличается тем, что тип данных у параметров выбирается автоматически через AddWithValue()
        //--------------------------------------------------------------
        public bool SqlExecuteNonQuery_Implicit(params NpgsqlCommand[] commands)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            NpgsqlTransaction transaction = null;
            bool hasFailed = false;
            try
            {
                conn.Open();
                using (transaction = conn.BeginTransaction())
                {
                    foreach (NpgsqlCommand command in commands)
                    {
                        command.Connection = conn;
                        int rows = command.ExecuteNonQuery();
                        if (rows == 0)
                        {
                            hasFailed = true;
                        }
                    }
                    
                    if (hasFailed)
                    {
                        transaction.Rollback();
                        return false;
                    }
                    else
                    {
                        transaction.Commit();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
        }

        //--------------------------------------------------------------
        // GetFirstRowAsString -- возвращает результат запроса SELECT как string
        //--------------------------------------------------------------
        public string GetFirstRowAsString(string query)
        {
            // TODO: поменять на ExecuteScalar() при необходимости

            NpgsqlConnection conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                using (var command = new NpgsqlCommand(query, conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                        return reader[0].ToString();
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

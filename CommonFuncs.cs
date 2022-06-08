using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PersonnelMgt
{
    public class CommonFuncs
    {
        ConnDB conn = ConnDB.Instance;

        //--------------------------------------------------------------
        // класс ReportDeptsFound -- перечень департаментов в списке у Отчёта № 2
        //
        // Параметры: position - номер строки, с которой начинаются записи деп-та, text - наим., size - кол-во строк
        //--------------------------------------------------------------
        public class ReportDeptsFound
        {
            public int Position { get; set; }
            public string Text { get; set; }
            public int Size { get; set; }
        }

        //--------------------------------------------------------------
        // класс ListBoxValue -- кортежи из Значение и Текст для списков ListBox и ComboBox
        //--------------------------------------------------------------
        public class ListBoxValues
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        //--------------------------------------------------------------
        // класс SqlQueryAndParams -- хранит очередь SQL запросов и их параметров
        //--------------------------------------------------------------
        public class SqlQueryAndParams
        {
            public string QueryText { get; private set; }
            public List<SqlColumnAndParam> ListParams { get; private set; }
            public SqlQueryAndParams(string queryText, List<SqlColumnAndParam> listParams)
            {
                this.QueryText = queryText;
                this.ListParams = listParams;
            }
        }

        //--------------------------------------------------------------
        // SqlColumnAndParam -- заполняет параметры SQL запроса
        //--------------------------------------------------------------
        public class SqlColumnAndParam
        {
            public string Column { get; private set; }
            public NpgsqlParameter Parameter { get; private set; }

            // AddValue. Параметры:
            //
            // iterator - номер параметра
            // columnName - имя атрибута
            // value - значение типа [int, string, datetime, boolean]
            public void AddValue(int iterator, string columnName, object value)
            {
                var newParam = new NpgsqlParameter();

                if (value == null || value == DBNull.Value)
                    newParam.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Unknown;
                else if (value.GetType() == typeof(int))
                    newParam.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Boolean; 
                else if (value.GetType() == typeof(string))
                    newParam.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Date;
                else if (value.GetType() == typeof(DateTime))
                    newParam.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer; 
                else if (value.GetType() == typeof(bool))
                    newParam.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text; 
                else throw new ArgumentException("AddValue.value принимает только int, string, datetime или bool.");

                newParam.ParameterName = "p" + iterator.ToString();
                newParam.Value = value;

                this.Parameter = newParam;
                this.Column = columnName;
            }
        }
        
        //--------------------------------------------------------------
        // TableFilterItem и другие -- хранит перечень фильтров для DataRowFilter
        //--------------------------------------------------------------
        public class TableFilterItem
        {
            public string Column { get; set; }
            public string Value { get; set; }
            public string Operator { get; set; }
        }

        public void TableFilterAdd(ref List<TableFilterItem> list, string column, string oper, string value)
        {
            var itemIndex = list.FindIndex(x => x.Column == column);
            
            if (itemIndex < 0)
            {
                var newItem = new CommonFuncs.TableFilterItem() { Column = column, Operator = oper, Value = value };
                list.Add(newItem);
            }
            else
            {
                list[itemIndex].Value = value;
            }
        }

        public void TableFilterRemove(ref List<TableFilterItem> list, string column)
        {
            var itemIndex = list.FindIndex(x => x.Column == column);
            if (itemIndex != -1)
                list.RemoveAt(itemIndex);
        }

        public string TableFilterToString(List<TableFilterItem> list)
        {
            if (list.Count == 0)
                return null;

            string filterString = "";
            foreach (TableFilterItem item in list)
                filterString += string.Format("[{0}] " + item.Operator + " {1} AND ", item.Column, item.Value);
            filterString = filterString.Substring(0, filterString.Length - 5);

            return filterString;
        }

        //--------------------------------------------------------------
        // AddTupleToList -- заполняет список параметров SQL запроса кортежами вида [атрибут, значение]
        //--------------------------------------------------------------
        public void AddTupleToList(ref List<CommonFuncs.SqlColumnAndParam> list, string column, object value)
        {
            int iterator = list.Count;
            var tuple = new CommonFuncs.SqlColumnAndParam();
            tuple.AddValue(iterator, column, value);
            list.Add(tuple);
        }

        //--------------------------------------------------------------
        // FillListFromSelect -- заполняет списки ListBox или ComboBox
        //
        // Параметры: control - ListBox или ComboBox, list - список вида ListBoxValues, sqlSelect - запрос
        //--------------------------------------------------------------
        public void FillListFromSelect(dynamic control, List<ListBoxValues> list, string sqlSelect, bool insertBlankRow = false)
        {
            if (!(control is ListBox || control is ComboBox))
                throw new ArgumentException("FillListFromSelect.control принимает только ListBox и ComboBox.");

            list.Clear();
            control.ValueMember = "Value";
            control.DisplayMember = "Text";

            // добавить пустое поле (сделать первое поле ComboBox пустым)
            if (insertBlankRow)
            {
                var blankRow = new ListBoxValues();
                blankRow.Value = -1;
                blankRow.Text = "";
                list.Add(blankRow);
            }

            DataTable dtResult = conn.SqlGetRows(sqlSelect);
            if (dtResult != null)
            {
                // заполнить данными
                foreach (DataRow row in dtResult.Rows)
                {
                    var listRow = new ListBoxValues();
                    listRow.Value = Convert.ToInt32(row["id"]);
                    listRow.Text = row["text"].ToString();
                    list.Add(listRow);
                }

                control.DataSource = list;
            }
            else
            {
                control.DataSource = null;
            }

            control.SelectedIndex = -1;
        }
    }
}

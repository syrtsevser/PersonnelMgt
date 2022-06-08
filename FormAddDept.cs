using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PersonnelMgt
{
    public partial class FormAddDept : Form
    {
        ConnDB conn = ConnDB.Instance;
        int selectedOrgID = -1;

        public FormAddDept(int orgID, string orgName)
        {
            InitializeComponent();

            selectedOrgID = orgID;
            txtOrgName.Text = orgName;
        }

        //--------------------------------------------------------------
        // Кнопка "Отменить"
        //--------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------------------------------------------
        // Кнопка "Добавить"
        //--------------------------------------------------------------
        private void btnAccept_Click(object sender, EventArgs e)
        {
            txtDeptName.Text = txtDeptName.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtDeptName.Text))
            {
                MessageBox.Show("Укажите наименование департамента.");
                txtDeptName.Focus();
                return;
            }

            var cf = new CommonFuncs();
            var listParams = new List<CommonFuncs.SqlColumnAndParam>();
            var listQueriesQueue = new List<CommonFuncs.SqlQueryAndParams>();
            btnAccept.Enabled = false;

            // проверка существования записи
            string queryCheck = @"SELECT * FROM departments WHERE id_org=:p0 AND name=:p1";
            cf.AddTupleToList(ref listParams, "id_org", selectedOrgID);
            cf.AddTupleToList(ref listParams, "name", txtDeptName.Text);
            DataTable dataResult = conn.SqlGetRows_Parametrized(queryCheck, listParams);

            if (dataResult != null && dataResult.Rows.Count > 0)
            {
                string msgText = string.Format(@"Департамент ""{0}"" уже существует!", txtDeptName.Text);
                MessageBox.Show(msgText);
                txtDeptName.Focus();
                btnAccept.Enabled = true;
                return;
            }

            listParams.Clear();

            // добавление записи в бд
            string query = @"INSERT INTO departments (id_org, name) VALUES (@org, @name)";
            var command = new NpgsqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Parameters.AddWithValue("@org", selectedOrgID);
            command.Parameters.AddWithValue("@name", txtDeptName.Text);

            if (!conn.SqlExecuteNonQuery_Implicit(command))
            {
                MessageBox.Show(this, "Не удалось добавить департамент!", "Добавить -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAccept.Enabled = true;
                return;
            }

            /*
            // добавление записи (старый код)
            string query = @"INSERT INTO departments (id_org, name) VALUES (:p0, :p1)";
            var command = new NpgsqlCommand();
            cf.AddTupleToList(ref listParams, "id_org", selectedOrgID);
            cf.AddTupleToList(ref listParams, "name", txtDeptName.Text);
            listQueriesQueue.Add(new CommonFuncs.SqlQueryAndParams(query, listParams));

            // добавление записи в базу
            if (!conn.SqlExecuteNonQuery_Consecutively(listQueriesQueue))
            {
                MessageBox.Show("Не удалось добавить департамент!");
                btnAccept.Enabled = true;
                return;
            }
            */

            // обновление списка в FormSelectDept
            if (Owner != null)
            {
                if (Owner.GetType() == typeof(FormSelectDept))
                {
                    (Owner as FormSelectDept).cmbOrg_SelectedIndexChanged(null, null);
                }
            }

            this.Close();
        }
    }
}

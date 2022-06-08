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
    public partial class FormAddRoom : Form
    {
        ConnDB conn = ConnDB.Instance;
        int selectedOrgID = -1;

        public FormAddRoom(int orgID)
        {
            InitializeComponent();

            selectedOrgID = orgID;
            txtNumber.Focus();
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
            txtNumber.Text = txtNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("Укажите наименование помещения.");
                txtNumber.Focus();
                return;
            }

            var cf = new CommonFuncs();
            var listParams = new List<CommonFuncs.SqlColumnAndParam>();
            var listQueriesQueue = new List<CommonFuncs.SqlQueryAndParams>();
            btnAccept.Enabled = false;

            // проверка существования записи
            string queryCheck = @"SELECT * FROM rooms WHERE id_org=:p0 AND number=:p1";
            cf.AddTupleToList(ref listParams, "id_org", selectedOrgID);
            cf.AddTupleToList(ref listParams, "number", txtNumber.Text);
            DataTable dataResult = conn.SqlGetRows_Parametrized(queryCheck, listParams);

            if (dataResult != null && dataResult.Rows.Count > 0)
            {
                string msgText = string.Format("Помещение с номером {0} уже существует!", txtNumber.Text);
                MessageBox.Show(msgText);
                txtNumber.Focus();
                btnAccept.Enabled = true;
                return;
            }

            listParams.Clear();

            // добавление записи в базу
            string query = @"INSERT INTO rooms (id_org, number, max_workplaces) VALUES (@org, @number, @maxwp)";
            var command = new NpgsqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Parameters.AddWithValue("@org", selectedOrgID);
            command.Parameters.AddWithValue("@number", txtNumber.Text);
            command.Parameters.AddWithValue("@maxwp", Decimal.ToInt32(Decimal.Floor(numericWorkplaces.Value)));

            if (!conn.SqlExecuteNonQuery_Implicit(command))
            {
                MessageBox.Show(this, "Не удалось добавить помещение!", "Добавить -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAccept.Enabled = true;
                return;
            }

            /*
            // добавление записи (старый код)
            string query = @"INSERT INTO rooms (id_org, number, max_workplaces) VALUES (:p0, :p1, :p2)";
            cf.AddTupleToList(ref listParams, "id_org", selectedOrgID);
            cf.AddTupleToList(ref listParams, "number", txtNumber.Text);
            cf.AddTupleToList(ref listParams, "max_workplaces", Decimal.ToInt32(Decimal.Floor(numericWorkplaces.Value)));
            listQueriesQueue.Add(new CommonFuncs.SqlQueryAndParams(query, listParams));

            if (!conn.SqlExecuteNonQuery_Consecutively(listQueriesQueue))
            {
                MessageBox.Show("Не удалось добавить помещение!");
                btnAccept.Enabled = true;
                return;
            }
            */

            // обновление списка в FormSelectRoom
            if (Owner != null)
            {
                if (Owner.GetType() == typeof(FormSelectRoom))
                {
                    (Owner as FormSelectRoom).cmbOrg_SelectedIndexChanged(null, null);
                }
            }

            this.Close();
        }
    }
}

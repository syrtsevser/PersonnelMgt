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
    public partial class FormSelectDept : Form
    {
        ConnDB conn = ConnDB.Instance;
        List<CommonFuncs.ListBoxValues> listTrackedOrgs = new List<CommonFuncs.ListBoxValues>();
        List<CommonFuncs.ListBoxValues> listTrackedDepts = new List<CommonFuncs.ListBoxValues>();

        public FormSelectDept(int? selectedOrgID = null)
        {
            InitializeComponent();

            // заполнить список "Организации"
            CommonFuncs cf = new CommonFuncs();
            string sqlSelect = @"SELECT id_org as ""id"", name as ""text"" FROM orgs";
            cf.FillListFromSelect(cmbOrg, listTrackedOrgs, sqlSelect);

            // автоматический выбор организации из выпадающего списка
            if (selectedOrgID != null)
                cmbOrg.SelectedValue = selectedOrgID;
        }

        //--------------------------------------------------------------
        // Список "организация" -> выбор организации
        //--------------------------------------------------------------
        internal void cmbOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDepts.DataSource = null;

            if (cmbOrg.SelectedIndex < 0)
                return;

            // заполнить список "Департаменты"
            CommonFuncs cf = new CommonFuncs();
            int selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;
            string sqlSelect = string.Format(@"SELECT id_dept as ""id"", name as ""text"" FROM departments WHERE id_org = {0}", selectedOrgID);
            cf.FillListFromSelect(listDepts, listTrackedDepts, sqlSelect);
        }

        //--------------------------------------------------------------
        // Кнопка "Выбрать"
        //--------------------------------------------------------------
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (listDepts.Items.Count == 0 || listDepts.SelectedIndex < 0)
                return;

            if (this.Owner != null)
            {
                // форма "Добавить сотрудника"
                if (this.Owner.GetType() == typeof(FormAddPerson))
                {
                    // поле "Организация"
                    ComboBox cmbOrg_owner = (this.Owner as FormAddPerson).Controls["cmbOrg"] as ComboBox;
                    cmbOrg_owner.SelectedValue = cmbOrg.SelectedValue;
                    (this.Owner as FormAddPerson).cmbOrg_SelectedIndexChanged(null, null);

                    // поле "Департамент"
                    ComboBox cmbDept_owner = (this.Owner as FormAddPerson).Controls["cmbDept"] as ComboBox;
                    cmbDept_owner.SelectedValue = listDepts.SelectedValue;
                }
            }
            this.Close();
        }

        //--------------------------------------------------------------
        // Кнопка "Отменить"
        //--------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------------------------------------------
        // Список "департаменты" -> двойной клик по департаменту
        //--------------------------------------------------------------
        private void listDepts_DoubleClick(object sender, EventArgs e)
        {
            // Дублирование кнопки "выбрать"
            btnAccept_Click(sender, e);
        }

        //--------------------------------------------------------------
        // Список "департаменты" -> кнопка "[+] добавить"
        //--------------------------------------------------------------
        private void btnAddDept_Click(object sender, EventArgs e)
        {
            if (cmbOrg.DataSource == null || cmbOrg.Items.Count == 0 || cmbOrg.SelectedIndex == -1)
                return;

            if (Application.OpenForms["FormAddDept"] as FormAddDept == null)
            {
                int selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;
                FormAddDept formNewDept = new FormAddDept(selectedOrgID, cmbOrg.Text);
                formNewDept.Owner = this;
                formNewDept.ShowDialog();
            }
            else
            {
                Application.OpenForms["FormAddDept"].BringToFront();
            }
        }

        //--------------------------------------------------------------
        // Список "департаменты" -> кнопка "[-] удалить"
        //--------------------------------------------------------------
        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            if (cmbOrg.DataSource == null || cmbOrg.SelectedIndex == -1 || listDepts.DataSource == null || listDepts.SelectedIndex == -1)
                return;

            int selectedDeptId = -1;
            try
            {
                selectedDeptId = Convert.ToInt32(listDepts.SelectedValue);
            }
            catch (Exception)
            {
                string msgText = "Не удалось удалить департамент! \n\nПричина: не удалось получить ID выделенного департамента.";
                MessageBox.Show(this, msgText, "Удалить департамент -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: предоставить перечень записей, которые будут удалены/занулированы. Можно даже сделать таймер перед нажатием "Да"

            // диалог
            string message = string.Format("Удалить департамент \"{0}\"? \n\nВсе данные, связанные с ним, будут также стёрты!", listDepts.Text);
            DialogResult reply = MessageBox.Show(this, message, "Удалить", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (reply == DialogResult.OK)
            {
                string query = @"DELETE FROM departments WHERE id_dept = @id";
                var command = new NpgsqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Parameters.AddWithValue("@id", selectedDeptId);

                if (!conn.SqlExecuteNonQuery_Implicit(command))
                {
                    MessageBox.Show(this, "Не удалось удалить департамент!", "Удалить департамент -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                /*
                // запрос в бд (старый код)
                var cf = new CommonFuncs();
                var listParams = new List<CommonFuncs.SqlColumnAndParam>();
                var listQueriesQueue = new List<CommonFuncs.SqlQueryAndParams>();

                // По идее, целостность остальных данных БД должна обработать сама.
                string query = @"DELETE FROM departments WHERE id_dept = :p0";
                cf.AddTupleToList(ref listParams, "id_dept", selectedDeptId);
                listQueriesQueue.Add(new CommonFuncs.SqlQueryAndParams(query, listParams));

                if (!conn.SqlExecuteNonQuery_Consecutively(listQueriesQueue))
                {
                    MessageBox.Show(this, "Не удалось удалить департамент!", "Удалить департамент -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                */

                // TODO: при удалении департамента, в окне "выбрать департамент" остальные выглядят как кракозябры, но работают. исправить.

                // обновление перечня департаментов в "Выбрать департамент"
                cmbOrg_SelectedIndexChanged(null, null);

                // обновление перечня департаментов в других формах
                if (Owner != null)
                {
                    // форма "Добавить сотрудника"
                    if (Owner.GetType() == typeof(FormAddPerson))
                    {
                        // поле "Организация"
                        (this.Owner as FormAddPerson).cmbOrg_SelectedIndexChanged(null, null);
                    }
                }
            }
        }
    }
}

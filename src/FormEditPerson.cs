using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Npgsql;

namespace PersonnelMgt
{
    public partial class FormEditPerson : Form
    {
        ConnDB conn = ConnDB.Instance;
        List<CommonFuncs.ListBoxValues> listTrackedOrgs = new List<CommonFuncs.ListBoxValues>();
        List<CommonFuncs.ListBoxValues> listTrackedDepts = new List<CommonFuncs.ListBoxValues>();
        List<CommonFuncs.ListBoxValues> listTrackedRooms = new List<CommonFuncs.ListBoxValues>();
        int personID = -1;
        int employeeID = -1;

        public FormEditPerson(int selectedPersonID, int selectedEmployeeID)
        {
            InitializeComponent();
            personID = selectedPersonID;
            employeeID = selectedEmployeeID;

            // заполнить список "Организации"
            CommonFuncs cf = new CommonFuncs();
            string sqlSelect = @"SELECT id_org as ""id"", name as ""text"" FROM orgs";
            cf.FillListFromSelect(cmbOrg, listTrackedOrgs, sqlSelect);

            // заполнить историю и поля
            GetPersonInfo();

            // временно скрыть панель инструментов у Истории трудоустройства
            tsHistory.Visible = false;
        }

        //--------------------------------------------------------------
        // GetPersonInfo -- заполняет персональные данные о личности (ФИО, дата рождения...)
        //--------------------------------------------------------------
        private void GetPersonInfo()
        {
            // запрос
            string sqlSelect = @"
SELECT employees.id_person, employees.id_employee, departments.id_dept, departments.id_org, rooms.id_room,
date_hired, date_dismissed, position, hours_week,
name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment
FROM employees
LEFT JOIN people ON employees.id_person = people.id_person
LEFT JOIN departments ON employees.id_dept = departments.id_dept
LEFT JOIN rooms ON rooms.id_room = employees.id_room
WHERE employees.id_person = {0}";

            // заполнить список "История работы"
            sqlSelect = string.Format(sqlSelect, personID);
            DataTable dataTable = conn.SqlGetRows(sqlSelect);
            dgvHistory.AutoGenerateColumns = false;
            dgvHistory.DataSource = dataTable;

            // заполнить поля
            txtLastName.Text = dataTable.Rows[0]["name_last"].ToString();
            txtFirstName.Text = dataTable.Rows[0]["name_first"].ToString();
            txtMiddleName.Text = dataTable.Rows[0]["name_middle"].ToString();
            txtEmail.Text = dataTable.Rows[0]["contact_email"].ToString();
            txtOtherContacts.Text = dataTable.Rows[0]["contact_other"].ToString();
            txtComment.Text = dataTable.Rows[0]["comment"].ToString();

            // заполнить дату
            try
            {
                string dateBirthText = dataTable.Rows[0]["date_birth"].ToString();
                if (!string.IsNullOrWhiteSpace(dateBirthText))
                {
                    dtpDateBirth.Checked = true;
                    dtpDateBirth.Value = DateTime.Parse(dateBirthText);
                }
                else
                {
                    dtpDateBirth.Checked = false;
                }
                
            }
            catch (Exception) 
            {
                dtpDateBirth.Checked = false;
            }

            // заполнить номер телефона
            try
            {
                mtxtPhone.Text = dataTable.Rows[0]["contact_phone"].ToString().PadLeft(12);
            }
            catch (Exception)
            {
                mtxtPhone.Text = "".PadLeft(12);
            }

            // выбрать пункт в "История работы"
            DataGridViewRow row = dgvHistory.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[0].Value.Equals(employeeID))
                    .First();
            dgvHistory.ClearSelection();
            dgvHistory.CurrentCell = dgvHistory.Rows[row.Index].Cells["dgvcHistoryDateHired"];

            // продолжить заполнять поля, уже как о сотруднике
            dgvHistory_SelectionChanged(null, null);
        }

        private void dgvHistory_SelectionChanged(object sender, EventArgs e)
        {
            // выполнять событие только при ручном вводе, либо при первом открытии формы
            if (sender != null && !dgvHistory.Focused)
                return;

            if (dgvHistory.DataSource == null || dgvHistory.SelectedRows.Count == 0)
                return;

            // запомнить выбранное трудоустройство в глоб. переменную employeeID
            int.TryParse(dgvHistory.SelectedRows[0].Cells["dgvcHistoryIdEmployee"].Value.ToString(), out employeeID);
            DataTable dataTable = (dgvHistory.DataSource as DataTable);
            int rowIndex = dgvHistory.SelectedRows[0].Index;

            // заполнить поля о трудоустройстве
            cmbOrg.SelectedValue = dataTable.Rows[rowIndex]["id_org"];
            cmbDept.SelectedValue = dataTable.Rows[rowIndex]["id_dept"];
            cmbDept.SelectedValue = dataTable.Rows[rowIndex]["id_dept"];
            txtPosition.Text = dataTable.Rows[rowIndex]["position"].ToString();

            // выбрать помещение
            if (!string.IsNullOrWhiteSpace(dataTable.Rows[rowIndex]["id_room"].ToString()))
                cmbRoom.SelectedValue = dataTable.Rows[rowIndex]["id_room"];
            else
                cmbRoom.SelectedIndex = 0;

            // заполнить поле "часы/неделя"
            try
            {
                numericHoursWeek.Value = Convert.ToDecimal(dataTable.Rows[rowIndex]["hours_week"]);
            }
            catch (Exception) 
            {
                numericHoursWeek.Value = -1;
            }

            // выбрать дату найма
            try
            {
                string dateHiredText = dataTable.Rows[rowIndex]["date_hired"].ToString();
                if (!string.IsNullOrWhiteSpace(dateHiredText))
                {
                    dtpDateHired.Checked = true;
                    dtpDateHired.Value = DateTime.Parse(dateHiredText);
                }
                else
                {
                    dtpDateHired.Checked = false;
                }
            }
            catch (Exception) 
            {
                dtpDateHired.Checked = false;
            }

            // выбрать дату увольнения
            try
            {
                string dateDismissedText = dataTable.Rows[rowIndex]["date_dismissed"].ToString();
                if (!string.IsNullOrWhiteSpace(dateDismissedText))
                {
                    dtpDateDismissed.Checked = true;
                    dtpDateDismissed.Value = DateTime.Parse(dateDismissedText);
                }
                else
                {
                    dtpDateDismissed.Checked = false;
                }
            }
            catch (Exception)
            {
                dtpDateDismissed.Checked = false;
            }
        }

        //--------------------------------------------------------------
        // Список "Организация" -> выбор организации
        //--------------------------------------------------------------
        private void cmbOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDept.DataSource = null;
            cmbRoom.DataSource = null;

            if (cmbOrg.Items.Count == 0 || cmbOrg.SelectedIndex < 0)
                return;

            CommonFuncs cf = new CommonFuncs();
            int selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;

            // заполнить список "Департаменты"
            string sqlSelect = string.Format(@"SELECT id_dept as ""id"", name as ""text"" FROM departments WHERE id_org = {0}", selectedOrgID);
            cf.FillListFromSelect(cmbDept, listTrackedDepts, sqlSelect);

            // заполнить список "Помещения"
            sqlSelect = string.Format(@"SELECT id_room as ""id"", number as ""text"" FROM rooms WHERE id_org = {0}", selectedOrgID);
            cf.FillListFromSelect(cmbRoom, listTrackedRooms, sqlSelect, true);    // параметр true - вставить пустую строку
        }

        //--------------------------------------------------------------
        // Кнопка "Выбрать департамент"
        //--------------------------------------------------------------
        private void btnSelectDept_Click(object sender, EventArgs e)
        {
            /*
            if (Application.OpenForms["FormSelectDept"] as FormSelectDept == null)
            {
                int? selectedOrgID = null;
                if (cmbOrg.Items.Count > 0 && cmbOrg.SelectedIndex > -1)
                    selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;
                FormSelectDept formDept = new FormSelectDept(selectedOrgID);
                formDept.Owner = this;
                formDept.Show();
            }
            else
            {
                Application.OpenForms["FormSelectDept"].BringToFront();
            }
            */
        }

        //--------------------------------------------------------------
        // Кнопка "Выбрать помещение"
        //--------------------------------------------------------------
        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            /*
            if (Application.OpenForms["FormSelectRoom"] as FormSelectRoom == null)
            {
                int? selectedOrgID = null;
                if (cmbOrg.Items.Count > 0 && cmbOrg.SelectedIndex > -1)
                    selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;
                FormSelectRoom formRoom = new FormSelectRoom(selectedOrgID);
                formRoom.Owner = this;
                formRoom.Show();
            }
            */
        }

        //--------------------------------------------------------------
        // Кнопка "Отменить"
        //--------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------------------------------------------
        // Кнопка "Применить"
        //--------------------------------------------------------------
        private void btnAccept_Click(object sender, EventArgs e)
        {
            var listColumnValue_People = new List<CommonFuncs.SqlColumnAndParam>();    // список столбцов/значений, использ. для заполнения SQL таблицы
            var listColumnValue_Employee = new List<CommonFuncs.SqlColumnAndParam>();

            //----------------------------------------------------------

            // IsTxtEmpty() -- функция проверки отсутствия значения у TextBox
            bool IsTxtEmpty(TextBox txt)
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Заполните поля!");
                    txt.Focus();
                    return true;
                }
                return false;
            }

            // IsCmbNotSelected -- функция проверки отсутствия значения у ListBox или ComboBox
            bool IsCmbNotSelected(dynamic control)
            {
                if (!(control is ComboBox || control is ListBox))
                    throw new ArgumentException("IsCmbNotSelected принимает только ComboBox и ListBox.");

                if (control.SelectedIndex < 0)
                {
                    MessageBox.Show("Заполните поля!");
                    control.Focus();
                    return true;
                }
                return false;
            }

            //----------------------------------------------------------

            // Проверка заполнения обязательных полей, используя ИЛИ по короткой схеме
            if (IsTxtEmpty(txtLastName) || IsTxtEmpty(txtFirstName) || IsCmbNotSelected(cmbOrg) || IsCmbNotSelected(cmbDept) || IsTxtEmpty(txtPosition))
                return;

            var commandPerson = new NpgsqlCommand();
            var commandEmployee = new NpgsqlCommand();

            btnAccept.Enabled = false;
            var cf = new CommonFuncs();
            var listQueriesQueue = new List<CommonFuncs.SqlQueryAndParams>();


            // 1. Запись в таблицу People
            // Сбор обязательных полей
            cf.AddTupleToList(ref listColumnValue_People, "name_last", txtLastName.Text);
            cf.AddTupleToList(ref listColumnValue_People, "name_first", txtFirstName.Text);

            // Сбор дополнительных полей
            string phoneText = mtxtPhone.Text.Substring(mtxtPhone.Text.LastIndexOf(' ') + 1);

            if (!string.IsNullOrWhiteSpace(txtMiddleName.Text))
                cf.AddTupleToList(ref listColumnValue_People, "name_middle", txtMiddleName.Text);
            else
                cf.AddTupleToList(ref listColumnValue_People, "name_middle", null);

            if (dtpDateBirth.Checked)
                cf.AddTupleToList(ref listColumnValue_People, "date_birth", dtpDateBirth.Value);
            else
                cf.AddTupleToList(ref listColumnValue_People, "date_birth", null);

            if (mtxtPhone.MaskCompleted)
                cf.AddTupleToList(ref listColumnValue_People, "contact_phone", phoneText);
            else
                cf.AddTupleToList(ref listColumnValue_People, "contact_phone", null);

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                cf.AddTupleToList(ref listColumnValue_People, "contact_email", txtEmail.Text);
            else
                cf.AddTupleToList(ref listColumnValue_People, "contact_email", null);

            if (!string.IsNullOrWhiteSpace(txtOtherContacts.Text))
                cf.AddTupleToList(ref listColumnValue_People, "contact_other", txtOtherContacts.Text);
            else
                cf.AddTupleToList(ref listColumnValue_People, "contact_other", null);

            if (!string.IsNullOrWhiteSpace(txtComment.Text))
                cf.AddTupleToList(ref listColumnValue_People, "comment", txtComment.Text);
            else
                cf.AddTupleToList(ref listColumnValue_People, "comment", null);

            string sqlEditPerson = "";


            // 1.2. Редактирование существующей записи в People
            sqlEditPerson = "UPDATE people SET ";

            // формирование комманды для запроса
            foreach (var tuple in listColumnValue_People)
                sqlEditPerson += string.Format("{0} = @{1}, ", tuple.Column, tuple.Parameter.ParameterName);
            sqlEditPerson = sqlEditPerson.Substring(0, sqlEditPerson.Length - 2);
            sqlEditPerson += string.Format(" WHERE id_person = {0}", personID);

            // добавление атрибутов и параметров в текст запроса
            commandPerson.CommandType = CommandType.Text;
            commandPerson.CommandText = sqlEditPerson;
            foreach (var tuple in listColumnValue_People)
                commandPerson.Parameters.AddWithValue(tuple.Parameter.ParameterName, tuple.Parameter.Value ?? DBNull.Value);


            // 2. Запись в таблицу Employees
            // Подготовка к добавлению записи
            string sqlEditEmployee = "UPDATE employees SET ";

            // Сбор полей
            cf.AddTupleToList(ref listColumnValue_Employee, "id_dept", cmbDept.SelectedValue);

            // Инверсия даты найма и уволнения, если найм указан позднее уволнения
            if (dtpDateHired.Checked && dtpDateDismissed.Checked && dtpDateHired.Value > dtpDateDismissed.Value)
            {
                DateTime temp = dtpDateHired.Value;
                dtpDateHired.Value = dtpDateDismissed.Value;
                dtpDateDismissed.Value = temp;
            }


            if (!string.IsNullOrWhiteSpace(txtPosition.Text))
                cf.AddTupleToList(ref listColumnValue_Employee, "position", txtPosition.Text);
            else
                cf.AddTupleToList(ref listColumnValue_Employee, "position", null);

            if (dtpDateHired.Checked)
                cf.AddTupleToList(ref listColumnValue_Employee, "date_hired", dtpDateHired.Value);
            else
                cf.AddTupleToList(ref listColumnValue_Employee, "date_hired", null);

            if (dtpDateDismissed.Checked)
                cf.AddTupleToList(ref listColumnValue_Employee, "date_dismissed", dtpDateDismissed.Value);
            else
                cf.AddTupleToList(ref listColumnValue_Employee, "date_dismissed", null);

            if (numericHoursWeek.Value >= 0)
                cf.AddTupleToList(ref listColumnValue_Employee, "hours_week", Convert.ToInt32(numericHoursWeek.Value));
            else
                cf.AddTupleToList(ref listColumnValue_Employee, "hours_week", null);

            if (cmbRoom.Items.Count > 1 && cmbRoom.SelectedIndex > 0)   // первый пункт перечня пустой
                cf.AddTupleToList(ref listColumnValue_Employee, "id_room", cmbRoom.SelectedValue);
            else
                cf.AddTupleToList(ref listColumnValue_Employee, "id_room", null);


            // Добавление атрибутов и параметров в текст запроса
            foreach (var tuple in listColumnValue_Employee)
                sqlEditEmployee += string.Format("{0} = @{1}, ", tuple.Column, tuple.Parameter.ParameterName);
            sqlEditEmployee = sqlEditEmployee.Substring(0, sqlEditEmployee.Length - 2);
            sqlEditEmployee += string.Format(" WHERE id_employee = {0}", employeeID);

            // Добавление запроса для employees в очередь
            commandEmployee.CommandType = CommandType.Text;
            commandEmployee.CommandText = sqlEditEmployee;
            foreach (var tuple in listColumnValue_Employee)
            { 
                commandEmployee.Parameters.AddWithValue(tuple.Parameter.ParameterName, tuple.Parameter.Value ?? DBNull.Value);
                /*MessageBox.Show(string.Format("{0} = {1} ({2})\n\n\n{3}",
                        commandEmployee.Parameters[commandEmployee.Parameters.Count - 1].ParameterName,
                        commandEmployee.Parameters[commandEmployee.Parameters.Count - 1].Value.ToString(),
                        commandEmployee.Parameters[commandEmployee.Parameters.Count - 1].Value.GetType().ToString(),
                        sqlEditEmployee));*/
            }


            // Отправка очереди запросов под единой транзакцией
            if (!conn.SqlExecuteNonQuery_Implicit(commandPerson, commandEmployee))
            {
                MessageBox.Show(this, "Не удалось отредактировать сотрудника!", "Применить -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAccept.Enabled = true;
                return;
            }

            // Обновить перечень сотрудников в главном окне
            if (Owner != null && Owner.GetType() == typeof(FormMain))
                (Owner as FormMain).tsBtnPrsnRefresh_Click(null, null);

            this.Close();
        }
    }
}

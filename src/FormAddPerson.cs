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
    public partial class FormAddPerson : Form
    {
        ConnDB conn = ConnDB.Instance;
        List<CommonFuncs.ListBoxValues> listTrackedOrgs = new List<CommonFuncs.ListBoxValues>();
        List<CommonFuncs.ListBoxValues> listTrackedDepts = new List<CommonFuncs.ListBoxValues>();
        List<CommonFuncs.ListBoxValues> listTrackedRooms = new List<CommonFuncs.ListBoxValues>();
        private int? selectedExistingPersonId = null;

        public FormAddPerson()
        {
            InitializeComponent();

            // заполнить список "Организации"
            CommonFuncs cf = new CommonFuncs();
            string sqlSelect = @"SELECT id_org as ""id"", name as ""text"" FROM orgs";
            cf.FillListFromSelect(cmbOrg, listTrackedOrgs, sqlSelect);
            if (cmbOrg.Items.Count == 1)
                cmbOrg.SelectedIndex = 0;

            // форматирование элементов формы
            panelEditingExistingIcon.BackgroundImage = System.Drawing.SystemIcons.Warning.ToBitmap();
        }

        //--------------------------------------------------------------
        // EditingExistingPerson -- переключает режим добавления двух записей (people, employee)
        // ...в режим редактирования существующей (people) и добавления новой (employee)
        //--------------------------------------------------------------
        internal void EditingExistingPerson(bool startEditing, int? personId = null)
        {
            if (startEditing)
            {
                btnDiscardExistingInfo.Visible = true;
                panelEditingExistingIcon.Visible = true;
                lblEditingExisting.Visible = true;
                selectedExistingPersonId = personId;
            }
            else
            {
                btnDiscardExistingInfo.Visible = false;
                panelEditingExistingIcon.Visible = false;
                lblEditingExisting.Visible = false;
                selectedExistingPersonId = null;

                txtLastName.Text = string.Empty;
                txtFirstName.Text = string.Empty;
                txtMiddleName.Text = string.Empty;
                mtxtPhone.Text = "+7".PadRight(12);
                txtEmail.Text = string.Empty;
                txtOtherContacts.Text = string.Empty;
                txtComment.Text = string.Empty;
                dtpDateBirth.Value = DateTime.Today;
                dtpDateBirth.Checked = false;
            }
        }

        //--------------------------------------------------------------
        // Список "Организация" -> выбор организации
        //--------------------------------------------------------------
        internal void cmbOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDept.DataSource = null;
            cmbRoom.DataSource = null;

            if (cmbOrg.Items.Count == 0 || cmbOrg.SelectedIndex < 0)
                return;

            CommonFuncs cf = new CommonFuncs();
            int selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;

            // заполнить список "Департаменты"
            string sqlSelect = string.Format(@"SELECT id_dept as ""id"", name as ""text"" FROM departments WHERE id_org = {0} ORDER BY text", selectedOrgID);
            cf.FillListFromSelect(cmbDept, listTrackedDepts, sqlSelect);

            // заполнить список "Помещения"
            sqlSelect = string.Format(@"SELECT id_room as ""id"", number as ""text"" FROM rooms WHERE id_org = {0} ORDER BY text", selectedOrgID);
            cf.FillListFromSelect(cmbRoom, listTrackedRooms, sqlSelect, true);
        }

        //--------------------------------------------------------------
        // Кнопка "Выбрать зарегистрированного человека"
        //--------------------------------------------------------------
        private void btnSelectExistingPerson_Click(object sender, EventArgs e)
        {
            // TODO: автоматически применить фильтр "сейчас не работает"

            if (Application.OpenForms["FormSelectPerson"] as FormSelectPerson == null)
            {
                int? selectedOrgID = null;
                if (cmbOrg.Items.Count > 0 && cmbOrg.SelectedIndex > -1)
                    selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;
                FormSelectPerson formPerson = new FormSelectPerson(selectedOrgID);
                formPerson.Owner = this;
                formPerson.ShowDialog();
            }
            else
            {
                Application.OpenForms["FormSelectPerson"].BringToFront();
            }
        }

        //--------------------------------------------------------------
        // Кнопка "Отменить редактирование [X]"
        //--------------------------------------------------------------
        private void btnDiscardExistingInfo_Click(object sender, EventArgs e)
        {
            EditingExistingPerson(false);
        }

        //--------------------------------------------------------------
        // Кнопка "Выбрать департамент"
        //--------------------------------------------------------------
        private void btnSelectDept_Click(object sender, EventArgs e)
        {
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
        }

        //--------------------------------------------------------------
        // Кнопка "Выбрать помещение"
        //--------------------------------------------------------------
        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormSelectRoom"] as FormSelectRoom == null)
            {
                int? selectedOrgID = null;
                if (cmbOrg.Items.Count > 0 && cmbOrg.SelectedIndex > -1)
                    selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;
                FormSelectRoom formRoom = new FormSelectRoom(selectedOrgID);
                formRoom.Owner = this;
                formRoom.Show();
            }
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
            var listColumnValue_People = new List<CommonFuncs.SqlColumnAndParam>();    // список столбцов/значений, использ. для заполнения SQL таблицы
            var listColumnValue_Employee = new List<CommonFuncs.SqlColumnAndParam>();

            //----------------------------------------------------------

            // IsTxtEmpty -- функция проверки отсутствия значения у TextBox
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

            if (dtpDateBirth.Checked)
                cf.AddTupleToList(ref listColumnValue_People, "date_birth", dtpDateBirth.Value);

            if (mtxtPhone.MaskCompleted)
                cf.AddTupleToList(ref listColumnValue_People, "contact_phone", phoneText);

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                cf.AddTupleToList(ref listColumnValue_People, "contact_email", txtOtherContacts.Text);

            if (!string.IsNullOrWhiteSpace(txtOtherContacts.Text))
                cf.AddTupleToList(ref listColumnValue_People, "contact_other", txtOtherContacts.Text);

            if (!string.IsNullOrWhiteSpace(txtComment.Text))
                cf.AddTupleToList(ref listColumnValue_People, "comment", txtComment.Text);

            string sqlInsertPerson = "";


            // Проверка режима редактирования -- добавить новую запись в People, либо отредактировать существующую
            if (selectedExistingPersonId == null)
            {
                // 1.1. Создание новой записи в People
                sqlInsertPerson = "INSERT INTO people (";

                // Добавление атрибутов и параметров в текст запроса
                foreach (var tuple in listColumnValue_People)
                    sqlInsertPerson += tuple.Column + ", ";
                sqlInsertPerson = sqlInsertPerson.Substring(0, sqlInsertPerson.Length - 2) + ") VALUES (";

                foreach (var tuple in listColumnValue_People)
                    sqlInsertPerson += "@" + tuple.Parameter.ParameterName + ", ";
                sqlInsertPerson = sqlInsertPerson.Substring(0, sqlInsertPerson.Length - 2) + ")";

                // Добавление запроса для people в очередь (старый код)
                //listQueriesQueue.Add(new CommonFuncs.SqlQueryAndParams(sqlInsertPerson, listColumnValue_People));
            }
            else
            {
                // 1.2. Редактирование существующей записи в People
                sqlInsertPerson = "UPDATE people SET ";

                // Добавление атрибутов и параметров в текст запроса
                foreach (var tuple in listColumnValue_People)
                    sqlInsertPerson += string.Format("{0} = @{1}, ", tuple.Column, tuple.Parameter.ParameterName);

                sqlInsertPerson = sqlInsertPerson.Substring(0, sqlInsertPerson.Length - 2);
                sqlInsertPerson += string.Format(" WHERE id_person = {0}", selectedExistingPersonId);

                // Добавление запроса для people в очередь (старый код)
                //listQueriesQueue.Add(new CommonFuncs.SqlQueryAndParams(sqlInsertPerson, listColumnValue_People));
            }

            // Занесение параметров в запрос для таблицы People
            commandPerson.CommandType = CommandType.Text;
            commandPerson.CommandText = sqlInsertPerson;
            foreach (var tuple in listColumnValue_People)
                commandPerson.Parameters.AddWithValue(tuple.Parameter.ParameterName, tuple.Parameter.Value);


            // 2. Запись в таблицу Employees
            // Подготовка к добавлению записи
            string sqlInsertEmployee = "INSERT INTO employees (id_person, ";

            // Сбор обязательных полей
            cf.AddTupleToList(ref listColumnValue_Employee, "id_dept", cmbDept.SelectedValue);
            cf.AddTupleToList(ref listColumnValue_Employee, "position", txtPosition.Text);

            // Инверсия даты найма и уволнения, если найм указан позднее уволнения
            if (dtpDateHired.Checked && dtpDateDismissed.Checked && dtpDateHired.Value > dtpDateDismissed.Value)
            {
                DateTime temp = dtpDateHired.Value;
                dtpDateHired.Value = dtpDateDismissed.Value;
                dtpDateDismissed.Value = temp;
            }


            // Сбор дополнительных полей
            if (dtpDateHired.Checked)
                cf.AddTupleToList(ref listColumnValue_Employee, "date_hired", dtpDateHired.Value);

            if (dtpDateDismissed.Checked)
                cf.AddTupleToList(ref listColumnValue_Employee, "date_dismissed", dtpDateDismissed.Value);

            if (numericHoursWeek.Value >= 0)
                cf.AddTupleToList(ref listColumnValue_Employee, "hours_week", Convert.ToInt32(numericHoursWeek.Value));

            if (cmbRoom.Items.Count > 1 && cmbRoom.SelectedIndex > 0)   // первый пункт перечня пустой
                cf.AddTupleToList(ref listColumnValue_Employee, "id_room", cmbRoom.SelectedValue);


            // Добавление атрибутов и параметров в текст запроса
            foreach (var tuple in listColumnValue_Employee)
                sqlInsertEmployee += tuple.Column + ", ";
            sqlInsertEmployee = sqlInsertEmployee.Substring(0, sqlInsertEmployee.Length - 2);

            // Проверка режима редактирования -- создать новый Person или использовать существующий
            if (selectedExistingPersonId == null)
                sqlInsertEmployee += ") VALUES((SELECT max(id_person) FROM people), ";
            else
                sqlInsertEmployee += string.Format(") VALUES({0}, ", selectedExistingPersonId);

            foreach (var tuple in listColumnValue_Employee)
                sqlInsertEmployee += "@" + tuple.Parameter.ParameterName + ", ";
            sqlInsertEmployee = sqlInsertEmployee.Substring(0, sqlInsertEmployee.Length - 2) + ")";

            // Добавление запроса для employees в очередь
            commandEmployee.CommandType = CommandType.Text;
            commandEmployee.CommandText = sqlInsertEmployee;
            foreach (var tuple in listColumnValue_Employee)
                commandEmployee.Parameters.AddWithValue(tuple.Parameter.ParameterName, tuple.Parameter.Value);


            // Отправка очереди запросов под единой транзакцией
            if (!conn.SqlExecuteNonQuery_Implicit(commandPerson, commandEmployee))
            {
                MessageBox.Show(this, "Не удалось добавить сотрудника!", "Добавить -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAccept.Enabled = true;
                return;
            }

            // Обновить перечень сотрудников
            if (Owner != null && Owner.GetType() == typeof(FormMain))
                (Owner as FormMain).tsBtnPrsnRefresh_Click(null, null);

            this.Close();
        }
    }
}

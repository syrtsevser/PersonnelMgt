using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PersonnelMgt
{
    public partial class FormSelectPerson : Form
    {
        ConnDB conn = ConnDB.Instance;
        List<CommonFuncs.ListBoxValues> listTrackedOrgs = new List<CommonFuncs.ListBoxValues>();
        List<CommonFuncs.TableFilterItem> listTableFilter = new List<CommonFuncs.TableFilterItem>();

        public FormSelectPerson(int? selectedOrgID = null)
        {
            InitializeComponent();

            // TODO: автоматически применить фильтр "сейчас не работает"

            // форматирование таблицы Люди
            dgvPeople.AutoGenerateColumns = false;
            if (dgvPeople.ColumnCount > 0)
                dgvPeople.Columns[dgvPeople.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // заполнить список "Организации"
            CommonFuncs cf = new CommonFuncs();
            string sqlSelect = @"SELECT id_org as ""id"", name as ""text"" FROM orgs";
            cf.FillListFromSelect(cmbOrg, listTrackedOrgs, sqlSelect);

            // автоматический выбор организации из выпадающего списка
            if (selectedOrgID != null && cmbOrg.Items.Count > 0)
                cmbOrg.SelectedValue = selectedOrgID;
            FillPeopleTable(selectedOrgID);

            // автоматический выбор фильтра "ранее работал"
            cmbFilterHasWorked.SelectedIndex = 0;

            // скрытие колонок ID (временное решения для бага)
            dgvcPeopleIdPerson.Visible = false;
        }

        //--------------------------------------------------------------
        // FillPeopleTable -- заполняет таблицу людьми (person, не employee)
        //--------------------------------------------------------------
        private void FillPeopleTable(int? selectedOrgID = null)
        {
            // TODO: поменять флаги "ранее работал.." на дату/должность, причём привязать только одну (наипозднюю) запись из Employees
            // TODO: добавить проверку, если личность уже трудоустроена в виде "Вы уверены...?"

            string query = @"
SELECT people.id_person, name_last, name_first, name_middle, date_birth, contact_phone,
(CASE WHEN EXISTS
	(SELECT * FROM employees
	LEFT JOIN departments ON employees.id_dept = departments.id_dept 
	WHERE id_person = people.id_person AND id_org = {0}) 
		THEN true 
		ELSE false 
END) as ever_worked,
(CASE WHEN EXISTS
	(SELECT * FROM employees
	LEFT JOIN departments ON employees.id_dept = departments.id_dept 
	WHERE id_person = people.id_person AND id_org = {0} AND date_dismissed is null) 
		THEN true 
		ELSE false 
END) as working_now
FROM people
ORDER BY name_last ASC";

            // добавление параметра id_org = cmbOrg.SelectedValue
            // если же Организация не выбрана, тогда все колонки "работал ли" выведут false
            query = string.Format(query, selectedOrgID ?? -1);

            // выполнение запроса
            DataTable dataTable = conn.SqlGetRows(query);
            dgvPeople.DataSource = dataTable;

            /*
            // Альтернативный код: использование параметрического запроса. (Пока нету необходимости.)
            var cf = new CommonFuncs();
            var listParams = new List<CommonFuncs.SqlColumnAndParam>();
            cf.AddTupleToList(ref listParams, "id_org", selectedOrgID ?? -1);

            if (listParams.Count > 0)
                query = string.Format(query, listParams.Select(x => x.Parameter.Value).ToArray());
            DataTable dataTable = conn.SqlGetRows_Parametrized(query, listParams);
            dgvPeople.DataSource = dataTable;
            */
        }

        //--------------------------------------------------------------
        // Список "организации" -> выбор организации
        //--------------------------------------------------------------
        private void cmbOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPeople.DataSource = null;

            if (cmbOrg.SelectedIndex < 0)
                return;

            // заполнение таблицы
            int selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;
            FillPeopleTable(selectedOrgID);

            // обновление фильтра
            cmbFilterHasWorked_SelectedIndexChanged(sender, e);
        }

        //--------------------------------------------------------------
        // Фильтры -> заполнение строки "Фамилия"
        //--------------------------------------------------------------
        private async void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            // ожидание окончания ввода текста 150 мс
            async Task<bool> UserKeepsTyping()
            {
                string txt = txtFilterName.Text;
                await Task.Delay(150);
                return txt != txtFilterName.Text;
            }
            if (await UserKeepsTyping()) return;

            // продолжение исполнение кода по истечению таймера
            if (dgvPeople.DataSource == null)
                return;

            // фильтрация по Фамилии в виде name_last LIKE '%текст%'
            var cf = new CommonFuncs();
            if (string.IsNullOrWhiteSpace(txtFilterName.Text))
            {
                cf.TableFilterRemove(ref listTableFilter, "name_last");
            }
            else
            {
                string value = string.Format("'%{0}%'", txtFilterName.Text);
                cf.TableFilterAdd(ref listTableFilter, "name_last", "LIKE", value);
            }

            // применение фильтра
            (dgvPeople.DataSource as DataTable).DefaultView.RowFilter = cf.TableFilterToString(listTableFilter);
            cmbFilterHasWorked_SelectedIndexChanged(sender, e);
        }

        //--------------------------------------------------------------
        // Фильтр -> кнопка "[x] сбросить"
        //--------------------------------------------------------------
        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtFilterName.Text = string.Empty;
        }

        //--------------------------------------------------------------
        // Фильтр -> список "ранее работал" -> смена пункта
        //--------------------------------------------------------------
        private void cmbFilterHasWorked_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvPeople.DataSource == null || cmbOrg.DataSource == null || cmbOrg.SelectedIndex < 0)
                return;

            CommonFuncs cf = new CommonFuncs();
            switch(cmbFilterHasWorked.SelectedIndex)
            {
                case 1:
                    // ранее не работал
                    cf.TableFilterAdd(ref listTableFilter, "ever_worked", "=", "false");
                    cf.TableFilterAdd(ref listTableFilter, "working_now", "=", "false");
                    break;
                case 2:
                    // ранее работал (но не сейчас)
                    cf.TableFilterAdd(ref listTableFilter, "ever_worked", "=", "true");
                    cf.TableFilterAdd(ref listTableFilter, "working_now", "=", "false");
                    break;
                case 3:
                    // сейчас работает
                    cf.TableFilterAdd(ref listTableFilter, "working_now", "=", "true");
                    cf.TableFilterRemove(ref listTableFilter, "ever_worked");
                    break;
                default:
                    // фильтр не выбран (показать всё)
                    cf.TableFilterRemove(ref listTableFilter, "ever_worked");
                    cf.TableFilterRemove(ref listTableFilter, "working_now");
                    break;
            }

            (dgvPeople.DataSource as DataTable).DefaultView.RowFilter = cf.TableFilterToString(listTableFilter);
        }

        //--------------------------------------------------------------
        // Кнопка "Выбрать"
        //--------------------------------------------------------------
        private void btnSelect_Click(object sender, EventArgs e)
        {
            void EditOwnerTextbox(ref DataTable dataTable, string controlName, string columnName)
            {
                TextBox txt_owner = (Owner as FormAddPerson).Controls[controlName] as TextBox;
                txt_owner.Text = dataTable.Rows[0][columnName].ToString();
            }

            if (dgvPeople.DataSource == null || dgvPeople.SelectedRows.Count == 0)
                return;

            if (Owner != null)
            {
                // форма "Добавить сотрудника"
                if (Owner.GetType() == typeof(FormAddPerson))
                {
                    FormAddPerson ownerForm = Owner as FormAddPerson;

                    // получение полного списка сведений о человеке
                    string personIdText = dgvPeople.SelectedRows[0].Cells["dgvcPeopleIdPerson"].Value.ToString();
                    string query = string.Format(@"SELECT * FROM people WHERE id_person = {0}", personIdText);
                    DataTable dataTable = conn.SqlGetRows(query);

                    if (dataTable == null || dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Не удалось выбрать пользователя!");
                        return;
                    }

                    // переключение режима добавления
                    // При нажатии "Добавить сотрудника" -> "Добавить", будет отредактирована существ. личность в People
                    ownerForm.EditingExistingPerson(true, Int32.Parse(personIdText));

                    // заполнение текстовых полей
                    EditOwnerTextbox(ref dataTable, "txtLastName", "name_last");
                    EditOwnerTextbox(ref dataTable, "txtFirstName", "name_first");
                    EditOwnerTextbox(ref dataTable, "txtMiddleName", "name_middle");
                    EditOwnerTextbox(ref dataTable, "txtEmail", "contact_email");
                    EditOwnerTextbox(ref dataTable, "txtOtherContacts", "contact_other");
                    EditOwnerTextbox(ref dataTable, "txtComment", "comment");

                    // заполнение поля даты рождения
                    string dateBirthText = dataTable.Rows[0]["date_birth"].ToString();
                    DateTimePicker dtpDateBirth_owner = ownerForm.Controls["dtpDateBirth"] as DateTimePicker;
                    DateTime dateBirthParsed;
                    if (!string.IsNullOrEmpty(dateBirthText) && DateTime.TryParse(dateBirthText, out dateBirthParsed))
                    {
                        dtpDateBirth_owner.Value = dateBirthParsed;
                        dtpDateBirth_owner.Checked = true;
                    }
                    else
                    {
                        dtpDateBirth_owner.Value = DateTime.Today;
                        dtpDateBirth_owner.Checked = false;
                    }

                    // заполнение поля номера телефона
                    string phoneText = dataTable.Rows[0]["contact_phone"].ToString().PadLeft(12, '_');
                    MaskedTextBox mtxtPhone_owner = ownerForm.Controls["mtxtPhone"] as MaskedTextBox;
                    mtxtPhone_owner.Text = "+7".PadRight(12);
                    if (!string.IsNullOrWhiteSpace(phoneText))
                    {
                        try
                        {
                            mtxtPhone_owner.Text = phoneText;
                        }
                        catch (Exception) { }
                    }
                }
            }
            this.Close();
        }

        //--------------------------------------------------------------
        // Список "люди" -> двойной клик по личности
        //--------------------------------------------------------------
        private void dgvPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        //--------------------------------------------------------------
        // Кнопка "Отменить"
        //--------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

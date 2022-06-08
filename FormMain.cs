using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PersonnelMgt
{
    public partial class FormMain : Form
    {
        ConnDB conn = ConnDB.Instance;
        List<CommonFuncs.TableFilterItem> listPersonnelTableFilter = new List<CommonFuncs.TableFilterItem>();
        List<CommonFuncs.ListBoxValues> listReportsTrackedOrgs = new List<CommonFuncs.ListBoxValues>();

        public FormMain()
        {
            InitializeComponent();

            // Спрятать вкладки, используемые при дизайне
            tabControlMain.Appearance = TabAppearance.FlatButtons;
            tabControlMain.ItemSize = new Size(0, 1);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlReports.Appearance = TabAppearance.FlatButtons;
            tabControlReports.ItemSize = new Size(0, 1);
            tabControlReports.SizeMode = TabSizeMode.Fixed;

            // Заполнение таблицы Сотрудники
            dgvPersonnelTable.AutoGenerateColumns = false;
            if (dgvPersonnelTable.ColumnCount > 0)
                dgvPersonnelTable.Columns[dgvPersonnelTable.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FillPersonnelTable();

            // Включить фильтр "показать только сейчас работающих"
            tsBtnPrsnToggleConcurrent_Click(null, null);

            // Заполнить Отчёты -> список Организации
            CommonFuncs cf = new CommonFuncs();
            string sqlSelect = @"SELECT id_org as ""id"", name as ""text"" FROM orgs";
            cf.FillListFromSelect(cmbReportOrg, listReportsTrackedOrgs, sqlSelect);
            if (cmbReportOrg.Items.Count == 1)
                cmbReportOrg.SelectedIndex = 0;

            // Заполнить Отчёты -> фильтр Год
            mtxtReport3_Year.Text = (DateTime.Now.Year - 1).ToString();
        }

        //--------------------------------------------------------------
        // FillPersonnelTable -- заполнить таблицу Сотрудники
        //--------------------------------------------------------------
        private void FillPersonnelTable()
        {
            string query = @"
SELECT (name_last || ' ' || name_first) as name,
(name_last || ' ' || name_first || ' ' || name_middle) as name_full,
name_last, name_first, name_middle, departments.name as dept_name, 
people.id_person, employees.id_employee, position, 
rooms.number as room_number, date_hired, date_dismissed, date_birth, hours_week,
contact_phone, contact_email, contact_other, 
(SELECT count(*) FROM hardware_lease, people WHERE hardware_lease.id_person = people.id_person) as hardware_cnt,
(SELECT count(*) FROM keys_lease, people WHERE keys_lease.id_person = people.id_person) as keys_cnt
FROM people 
RIGHT JOIN employees ON people.id_person = employees.id_person 
LEFT JOIN departments ON employees.id_dept = departments.id_dept
LEFT JOIN rooms ON employees.id_room = rooms.id_room
ORDER BY name ASC, date_dismissed DESC";

            DataTable dataTable = conn.SqlGetRows(query);
            dgvPersonnelTable.DataSource = dataTable;

            // применить фильтры
            var cf = new CommonFuncs();
            if (listPersonnelTableFilter.Count > 0)
                (dgvPersonnelTable.DataSource as DataTable).DefaultView.RowFilter = cf.TableFilterToString(listPersonnelTableFilter);
            else
                (dgvPersonnelTable.DataSource as DataTable).DefaultView.RowFilter = null;
        }

        //--------------------------------------------------------------
        // ClearEmployeeExtraInfo -- сброс полей доп. информации выделенных сотрудников
        //--------------------------------------------------------------
        private void ClearEmployeeExtraInfo()
        {
            // ClearValue -- сбрасывает значения для элементов типа TextBox, Label и DateTimePicker
            void ClearValue(params Control[] controls)
            {
                foreach (var control in controls)
                {
                    if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(Label))
                    {
                        control.Text = string.Empty;
                    }
                    else if (control.GetType() == typeof(DateTimePicker))
                    {
                        ((DateTimePicker)control).Value = DateTime.Today;
                    }
                }
            }

            // сброс значений перечня в форме Сотрудники -> Основная информация (и другие)
            ClearValue(txtPrsFullName1, txtPrsPosition, txtPrsRoomNum, txtPrsHoursWeek, txtPrsContactPhone, txtPrsContactEmail,
                    txtPrsContactOther, txtPrsDateBirth, txtPrsDateHired, txtPrsDateDismissed,
                    txtPrsFullName2, txtPrsFullName3);
        }

        //--------------------------------------------------------------
        // Закрытие окна
        //--------------------------------------------------------------
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //--------------------------------------------------------------
        // Заморозка форматирования UI при изменении размера окна, повышая производительность
        //--------------------------------------------------------------
        private void FormMain_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout();
        }

        //--------------------------------------------------------------
        // splitContainer -- Предотвращение потери фокуса при перемещении разделителей
        //--------------------------------------------------------------
        private Control lastFocusedControl = null;

        private Control getFocusedControl(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c.Focused)
                {
                    return c;
                }
                else if (c.ContainsFocus)
                {
                    return getFocusedControl(c.Controls);
                }
            }
            return null;
        }

        private void splitContainer_MouseDown(object sender, MouseEventArgs e)
        {
            lastFocusedControl = getFocusedControl(this.Controls);
        }

        private void splitContainer_MouseUp(object sender, MouseEventArgs e)
        {
            if (lastFocusedControl != null)
            {
                lastFocusedControl.Focus();
                lastFocusedControl = null;
            }
        }

        //--------------------------------------------------------------
        // меню Файл -> Настройки
        //--------------------------------------------------------------
        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();
        }

        //--------------------------------------------------------------
        // меню Файл -> Выход
        //--------------------------------------------------------------
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--------------------------------------------------------------
        // меню Справка -> О программе
        //--------------------------------------------------------------
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null, "ИС \"Сотрудники компании\" \nВерсия 1 (май 2022) \n\nВыполнил студент ВятГУ Сырцев С.А.",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //--------------------------------------------------------------
        // левая панель -> кнопка Сотрудники
        //--------------------------------------------------------------
        private void tsBtnPersonnel_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPagePersonnel;
        }

        //--------------------------------------------------------------
        // левая панель -> кнопка Отчёты
        //--------------------------------------------------------------
        private void tsBtnReports_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPageReports;

            if (cmbReportType.SelectedIndex == -1)
                cmbReportType.SelectedIndex = 0;
        }

        //--------------------------------------------------------------
        // Сотрудники -> верх. панель -> Обновить
        //--------------------------------------------------------------
        internal void tsBtnPrsnRefresh_Click(object sender, EventArgs e)
        {
            FillPersonnelTable();
        }

        //--------------------------------------------------------------
        // Сотрудники -> верх. панель -> Добавить
        //--------------------------------------------------------------
        private void tsBtnPrsnAdd_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormAddPerson"] as FormAddPerson == null)
            {
                FormAddPerson formAdd = new FormAddPerson();
                formAdd.Owner = this;
                formAdd.Show();
            }
            else
            {
                Application.OpenForms["FormAddPerson"].BringToFront();
            }
        }

        //--------------------------------------------------------------
        // Сотрудники -> верх. панель -> Редактировать
        //--------------------------------------------------------------
        private void tsBtnPrsnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPersonnelTable.DataSource == null || dgvPersonnelTable.SelectedCells.Count == 0)
                return;

            int personID = -1;
            int employeeID = -1;
            int.TryParse(dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesIdPerson"].Value.ToString(), out personID);
            int.TryParse(dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesIdEmployee"].Value.ToString(), out employeeID);

            if (Application.OpenForms["FormEditPerson"] as FormEditPerson == null)
            {
                FormEditPerson formEdit = new FormEditPerson(personID, employeeID);
                formEdit.Owner = this;
                formEdit.ShowDialog();
            }
            else
            {
                Application.OpenForms["FormEditPerson"].BringToFront();
            }
        }

        //--------------------------------------------------------------
        // Сотрудники -> выделение сотрудника в списке (клик мыши)
        //--------------------------------------------------------------
        private void dgvPersonnelTable_SelectionChanged(object sender, EventArgs e)
        {
            // AssignDateToTextBox -- осуществляет попытку считать дату из таблицы и конвертировать в текст
            void AssignDateToTextBox(TextBox control, object value)
            {
                try
                {
                    control.Text = ((DateTime)value).ToString("dd.MM.yyyy");
                }
                catch (Exception) 
                {
                    control.Text = string.Empty;
                }
            }

            // проверка наличия данных
            if (dgvPersonnelTable.DataSource == null || dgvPersonnelTable.SelectedRows.Count == 0)
            {
                ClearEmployeeExtraInfo();   // очистка доп. информации
                return;
            }

            // вкладка Осн. информация
            txtPrsFullName1.Text = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesNameFull"].Value.ToString();
            txtPrsPosition.Text = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesPosition"].Value.ToString();
            txtPrsRoomNum.Text = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesRoomNum"].Value.ToString();
            txtPrsHoursWeek.Text = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesHoursWeek"].Value.ToString();
            txtPrsContactPhone.Text = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesContactPhone"].Value.ToString();
            txtPrsContactEmail.Text = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesContactEmail"].Value.ToString();
            txtPrsContactOther.Text = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesContactOther"].Value.ToString();

            // вкладка Осн. информация, добавление даты
            AssignDateToTextBox(txtPrsDateBirth, dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesDateBirth"].Value);
            AssignDateToTextBox(txtPrsDateHired, dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesDateHired"].Value);
            AssignDateToTextBox(txtPrsDateDismissed, dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesDateDismissed"].Value);

            // вкладка Сертификаты
            txtPrsFullName2.Text = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesNameFull"].Value.ToString();

            // вкладка Хранение
            txtPrsFullName3.Text = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesNameFull"].Value.ToString();
        }


        //--------------------------------------------------------------
        // Сотрудники -> двойной клик по сотруднику
        //--------------------------------------------------------------
        private void dgvPersonnelTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsBtnPrsnEdit_Click(sender, e);
        }

        //--------------------------------------------------------------
        // Сотрудники -> верх. панель -> Показать историю работавших
        //--------------------------------------------------------------
        private void tsBtnPrsnToggleConcurrent_Click(object sender, EventArgs e)
        {
            if (dgvPersonnelTable.DataSource == null)
                return;

            // добавить/стереть фильтр, переключение его
            var cf = new CommonFuncs();
            if (listPersonnelTableFilter.Count > 0 && listPersonnelTableFilter.Exists(x => x.Column == "date_dismissed"))
                cf.TableFilterRemove(ref listPersonnelTableFilter, "date_dismissed");
            else
                cf.TableFilterAdd(ref listPersonnelTableFilter, "date_dismissed", "is", "null");

            // применить фильтр
            if (listPersonnelTableFilter.Count > 0)
                (dgvPersonnelTable.DataSource as DataTable).DefaultView.RowFilter = cf.TableFilterToString(listPersonnelTableFilter);
            else
                (dgvPersonnelTable.DataSource as DataTable).DefaultView.RowFilter = null;

            // Спрятать колонки ID (временное решение для бага)
            dgvcEmployeesIdPerson.Visible = false;
            dgvcEmployeesIdEmployee.Visible = false;
        }

        //--------------------------------------------------------------
        // Сотрудники -> верх. панель -> Уволить (сменить дату)
        //--------------------------------------------------------------
        private void tsBtnPrsnDismiss_Click(object sender, EventArgs e)
        {
            if (dgvPersonnelTable.DataSource == null || dgvPersonnelTable.SelectedRows.Count == 0)
                return;

            int selectedEmployeeID = -1;
            string selectedPersonName = "";
            try
            {
                selectedEmployeeID = Convert.ToInt32(dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesIdEmployee"].Value);
                selectedPersonName = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesName"].Value.ToString();
            }
            catch (Exception)
            {
                string msgText = "Увольнение не удалось! \n\nПричина: не удалось получить ID выделенного сотрудника.";
                MessageBox.Show(this, msgText, "Уволить -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // проверка на случай, если уже уволен
            var dismissedDate = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesDateDismissed"].Value;
            if (dismissedDate != null && dismissedDate != DBNull.Value && !string.IsNullOrWhiteSpace(dismissedDate.ToString()))
                return;

            // диалог
            string message = string.Format("Уволить сотрудника {0}?", selectedPersonName);
            DialogResult reply = MessageBox.Show(this, message, "Увольнение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (reply == DialogResult.OK)
            {
                // занесение увольнения через текущую дату
                string query = "UPDATE employees SET date_dismissed = @date WHERE id_employee = @id";
                var command = new NpgsqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Parameters.AddWithValue("@date", DateTime.Today);
                command.Parameters.AddWithValue("@id", selectedEmployeeID);

                if (!conn.SqlExecuteNonQuery_Implicit(command))
                {
                    MessageBox.Show(this, "Не удалось уволить сотрудника.", "Увольнение -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // обновление списка сотрудников
                FillPersonnelTable();
            }
        }

        //--------------------------------------------------------------
        // Сотрудники -> верх. панель -> Стереть данные о трудоустройстве (удалить)
        //--------------------------------------------------------------
        private void tsBtnPrsnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPersonnelTable.DataSource == null || dgvPersonnelTable.SelectedRows.Count == 0)
                return;

            int selectedEmployeeID = -1;
            string selectedPersonName = "";
            try
            {
                selectedEmployeeID = Convert.ToInt32(dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesIdEmployee"].Value);
                selectedPersonName = dgvPersonnelTable.SelectedRows[0].Cells["dgvcEmployeesName"].Value.ToString();
            }
            catch (Exception)
            {
                string msgText = "Не удалось стереть сотрудника! \n\nПричина: не удалось получить ID выделенного сотрудника.";
                MessageBox.Show(this, msgText, "Стереть данные о сотруднике -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // диалог
            // TODO: предоставить перечень данных, которые также будут удалены самой БД
            string message = string.Format("Стереть данные о сотруднике {0}?", selectedPersonName);
            DialogResult reply = MessageBox.Show(this, message, "Удалить сотрудника", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (reply == DialogResult.OK)
            {
                // запрос на удаление записи
                string query = "DELETE FROM employees WHERE id_employee = @id";
                var command = new NpgsqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Parameters.AddWithValue("@id", selectedEmployeeID);

                if (!conn.SqlExecuteNonQuery_Implicit(command))
                {
                    MessageBox.Show(this, "Не удалось удалить сотрудника!", "Удаление -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // обновление списка сотрудников
                FillPersonnelTable();
                string msgText = string.Format("Данные сотрудника {0} были стёрты.", selectedPersonName);
                MessageBox.Show(this, msgText, "Удалить сотрудника -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //--------------------------------------------------------------
        // Отчёты -> выбор вида отчёта
        //--------------------------------------------------------------
        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbReportType.SelectedIndex)
            {
                default:
                    tabControlReports.Visible = false;
                    chkReportSplitDepts.Visible = true;
                    break;
                case 0:
                    tabControlReports.Visible = true;
                    chkReportSplitDepts.Visible = true;
                    if (!chkReportSplitDepts.Checked)
                    {
                        tabControlReports.SelectedTab = tabPageReports1;
                        MakeReport1();
                    }
                    else
                    {
                        tabControlReports.SelectedTab = tabPageReports2;
                        MakeReport2();
                    }
                    break;
                case 1:
                    tabControlReports.Visible = true;
                    chkReportSplitDepts.Visible = false;
                    tabControlReports.SelectedTab = tabPageReports3;
                    MakeReport3();
                    break;
            }

            //----------------------------------------------------------

            // Отчёт 1 -- сотрудники
            void MakeReport1()
            {
                dgvReport1.AutoGenerateColumns = false;
                dgvcReport1_IdEmployee.Visible = false;

                if (cmbReportOrg.DataSource == null || cmbReportOrg.Items.Count == 0 || cmbReportOrg.SelectedIndex < 0)
                    return;

                // запрос в бд
                string query = @"
SELECT (name_last || ' ' || name_first || ' ' || name_middle) as name_full, date_hired, position
FROM employees
LEFT JOIN people ON employees.id_person = people.id_person
LEFT JOIN departments ON employees.id_dept = departments.id_dept
WHERE id_org = {0}
AND date_dismissed is null
ORDER BY date_hired DESC";
                query = string.Format(query, cmbReportOrg.SelectedValue);
                DataTable dataTable = conn.SqlGetRows(query);

                // проверка наслучай, если данных нету
                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Данные не удалось считать.\n\nВозможно, данных недостаточно.");
                    dgvReport1.DataSource = null;
                    return;
                }

                // создание столбца №
                int iterator = 1;
                dataTable.Columns.Add("row_n");
                foreach (DataRow row in dataTable.Rows)
                {
                    row["row_n"] = iterator.ToString();
                    iterator++;
                }

                // вставка строки "итого"
                int total = iterator - 1;
                dataTable.Rows.Add();
                DataRow newRowTotal = dataTable.NewRow();
                newRowTotal["name_full"] = "ИТОГО: " + total.ToString();
                dataTable.Rows.Add(newRowTotal);
                dataTable.Rows.Add();

                // привязывание DataSource
                dgvReport1.DataSource = dataTable;
            }

            //----------------------------------------------------------

            // Отчёт 2 -- департаменты
            void MakeReport2()
            {
                dgvReport2.AutoGenerateColumns = false;
                dgvcReport2_IdEmployee.Visible = false;
                dgvcReport2_IdDept.Visible = false;

                if (cmbReportOrg.DataSource == null || cmbReportOrg.Items.Count == 0 || cmbReportOrg.SelectedIndex < 0)
                    return;

                // запрос в бд
                string query = @"
SELECT (name_last || ' ' || name_first || ' ' || name_middle) as name_full, 
departments.name as dept_name, employees.id_dept, date_hired, position
FROM employees
LEFT JOIN people ON employees.id_person = people.id_person
LEFT JOIN departments ON departments.id_dept = employees.id_dept
WHERE id_org = {0}
AND date_dismissed is null
ORDER BY dept_name ASC, date_hired DESC";
                query = string.Format(query, cmbReportOrg.SelectedValue);
                DataTable dataTable = conn.SqlGetRows(query);

                // проверка на случай, если результатов нету
                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Данные не удалось считать.\n\nВозможно, данных недостаточно.");
                    dgvReport2.DataSource = null;
                    return;
                }

                // создание столбца №
                int iterator = 1;
                dataTable.Columns.Add("row_n");
                foreach (DataRow row in dataTable.Rows)
                {
                    row["row_n"] = iterator.ToString();
                    iterator++;
                }

                // извлечение списка департаментов, запоминая позиции уникальных наименований
                // Далее эта информация используется для вставки новых строк (наименование, кол-во, итого)
                var listDepts = new List<CommonFuncs.ReportDeptsFound>();
                int position = 0;
                int total = dataTable.Rows.Count;
                foreach (DataRow row in dataTable.Rows)
                {
                    string deptName = row["dept_name"].ToString();
                    if (listDepts.Count == 0)
                    {
                        listDepts.Add(new CommonFuncs.ReportDeptsFound() { Position = position, Text = deptName, Size = total });
                    }
                    else
                    {
                        if (!listDepts.Exists(x => x.Text == deptName))
                        {
                            listDepts.Add(new CommonFuncs.ReportDeptsFound() { Position = position, Text = deptName, Size = total });
                        }
                    }
                    position++;
                }

                // проверка на случай, если департаментов нету
                if (listDepts.Count == 0)
                {
                    dgvReport2.DataSource = null;
                    return;
                }

                // получение размера каждой группы департаментов
                for (int i = listDepts.Count - 1; i >= 0; i--)
                {
                    if (i == listDepts.Count - 1)
                    {
                        listDepts[i].Size -= listDepts[i].Position;
                    }
                    else
                    {
                        listDepts[i].Size = listDepts[i + 1].Position - listDepts[i].Position;
                    }
                }

                // DeptsOffset -- смещение позиций будущих департаментов из списка
                void DeptsOffset(int lastPos = 0)
                {
                    for (int i = lastPos; i < listDepts.Count; i++)
                        listDepts[i].Position ++;
                }

                // DeptsAddBlankRow -- вставка пустых строк или названий департаментов
                void DeptsAddBlankRow(int deptNum, bool includeName = false)
                {
                    DataRow newRowTMP = dataTable.NewRow();

                    if (includeName)
                        newRowTMP["name_full"] = listDepts[deptNum].Text;

                    dataTable.Rows.InsertAt(newRowTMP, listDepts[deptNum].Position);
                    DeptsOffset(deptNum);
                }

                // добавление текста ДЕПАРТАМЕНТ и ВСЕГО
                for (int i = 0; i < listDepts.Count; i++)
                {
                    // строка "кол-во", для каждого департамента [1:n)
                    // TODO: запомнить номер для дальнейш. форматирования
                    if (i != 0)
                    {
                        DataRow newRowSize2 = dataTable.NewRow();
                        newRowSize2["name_full"] = "Кол-во: " + listDepts[i - 1].Size.ToString();
                        dataTable.Rows.InsertAt(newRowSize2, listDepts[i].Position);
                        DeptsOffset(i);

                        DeptsAddBlankRow(i);
                    }

                    // строка Департамент
                    DeptsAddBlankRow(i, true);
                }
                
                // строка "кол-во", для последнего департамента
                DataRow newRowSize = dataTable.NewRow();
                newRowSize["name_full"] = "Кол-во: " + listDepts[listDepts.Count - 1].Size.ToString();
                dataTable.Rows.InsertAt(newRowSize, listDepts[listDepts.Count - 1].Position + listDepts[listDepts.Count - 1].Size);

                // вставка строки "итого"
                dataTable.Rows.Add();
                DataRow newRowTotal = dataTable.NewRow();
                newRowTotal["name_full"] = "ИТОГО: " + total.ToString();
                dataTable.Rows.Add(newRowTotal);
                dataTable.Rows.Add();

                /*
                foreach (var item in listDepts)
                    MessageBox.Show(string.Format("POS={0}.  NAME={1}.   SIZE={2}.", item.Position, item.Text, item.Size));
                */

                // привязывание DataSource
                dgvReport2.DataSource = dataTable;
            }

            //----------------------------------------------------------

            // Отчёт 3 -- прибыль/убыль
            void MakeReport3()
            {
                // ResetValues() -- сбрасывает значения формы
                void ResetValues(params Control[] controls)
                {
                    foreach (var control in controls)
                    {
                        if (control.GetType() == typeof(Label))
                            control.Text = "_";

                        if (control.GetType() == typeof(TextBox))
                            control.Text = "";
                    }
                }

                // SetValues() -- заполняет форму значениями
                void SetValues(DataTable queryResult, params Control[] controlsQuad)
                {
                    int i = 0;
                    foreach (var control in controlsQuad)
                    {
                        // если Label или TextBox
                        if (control.GetType() == typeof(Label) || control.GetType() == typeof(TextBox))
                        {
                            control.Text = queryResult.Rows[i].ItemArray[0].ToString();
                            i++;

                            if (i > 3)
                                break;
                        }
                    }
                }

                // CalcFunctions() -- рассчитывает "прибыль/убыль" и "текучка"
                void CalcFunctions(DataTable queryResult, Control control1, Control control2)
                {
                    if (control1.GetType() != typeof(TextBox) && control1.GetType() != typeof(Label) &&
                            control2.GetType() != typeof(TextBox) && control2.GetType() != typeof(Label))
                    {
                        throw new ArgumentException("Метод принимает только TextBox и Label.");
                    }

                    // исходные данные
                    double a, x, y, b;
                    try
                    {
                        a = Convert.ToDouble(queryResult.Rows[0].ItemArray[0]);  // кол-во на начало периода
                        x = Convert.ToDouble(queryResult.Rows[1].ItemArray[0]);  // сколько принято за период
                        y = Convert.ToDouble(queryResult.Rows[2].ItemArray[0]);  // сколько уволилось за период
                        b = Convert.ToDouble(queryResult.Rows[3].ItemArray[0]);  // кол-во на конец периода
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    // расчёт прибыли/убыли
                    // F1 = (B-A) / ((A + B )/2)
                    double F1 = (b - a) / ((a + b) / 2);

                    // расчёт текучки
                    // F2 = Y / ((A + B )/2)
                    double F2 = y / ((a + b) / 2);

                    // отлавливание NaN, округление до 14 знаков
                    if (Double.IsNaN(F1))
                        F1 = 0;

                    if (Double.IsNaN(F2))
                        F2 = 0;

                    F1 = Math.Round(F1, 14);
                    F2 = Math.Round(F2, 14);

                    // вывод результатов на экран
                    control1.Text = F1.ToString("G", CultureInfo.CreateSpecificCulture("ru-RU"));
                    control2.Text = F2.ToString("G", CultureInfo.CreateSpecificCulture("ru-RU"));
                }

                if (cmbReportOrg.DataSource == null || cmbReportOrg.Items.Count == 0 || cmbReportOrg.SelectedIndex < 0)
                    return;

                // сбросить все значения
                ResetValues(lblReport3_q1_1_Value, lblReport3_q1_2_Value, lblReport3_q1_3_Value, lblReport3_q1_4_Value, txtReport3_q1_F1, txtReport3_q1_F2,
                    lblReport3_q2_1_Value, lblReport3_q2_2_Value, lblReport3_q2_3_Value, lblReport3_q2_4_Value, txtReport3_q2_F1, txtReport3_q2_F2,
                    lblReport3_q3_1_Value, lblReport3_q3_2_Value, lblReport3_q3_3_Value, lblReport3_q3_4_Value, txtReport3_q3_F1, txtReport3_q3_F2,
                    lblReport3_q4_1_Value, lblReport3_q4_2_Value, lblReport3_q4_3_Value, lblReport3_q4_4_Value, txtReport3_q4_F1, txtReport3_q4_F2);

                // проверка, на случай если "год" не указан
                if (!mtxtReport3_Year.MaskFull)
                {
                    mtxtReport3_Year.Focus();
                    return;
                }

                // Запрос:
                // 1) кол-во на начало периода      (A)
                // 2) сколько принято за период     (X)
                // 3) сколько уволено за период     (Y)
                // 4) кол-во на конец периода       (B)
                string selectQuery = @"
SELECT count(*)
	FROM employees E1
	LEFT JOIN departments ON E1.id_dept = departments.id_dept
	WHERE departments.id_org = @org 
	AND date_hired < @date1 
	AND NOT EXISTS(
		SELECT * FROM employees E2
		WHERE E1.id_employee = E2.id_employee
		AND date_dismissed < @date1)

UNION ALL

SELECT count(*)
	FROM employees E1
	LEFT JOIN departments ON E1.id_dept = departments.id_dept
	WHERE departments.id_org = @org 
	AND date_hired > @date1 AND date_hired < @date2 

UNION ALL

SELECT count(*)
	FROM employees E1
	LEFT JOIN departments ON E1.id_dept = departments.id_dept
	WHERE departments.id_org = @org 
	AND date_dismissed > @date1 AND date_dismissed < @date2 
		
UNION ALL

SELECT count(*)
	FROM employees E1
	LEFT JOIN departments ON E1.id_dept = departments.id_dept
	WHERE departments.id_org = @org 
	AND date_hired < @date2 
	AND NOT EXISTS(
		SELECT * FROM employees E2
		WHERE E1.id_employee = E2.id_employee
		AND date_dismissed < @date2)";

                // формирование запросов
                NpgsqlCommand command_q1 = new NpgsqlCommand();
                command_q1.CommandType = CommandType.Text;
                command_q1.CommandText = selectQuery;
                command_q1.Parameters.AddWithValue("@org", cmbReportOrg.SelectedValue);
                var command_q2 = command_q1.Clone();
                var command_q3 = command_q1.Clone();
                var command_q4 = command_q1.Clone();

                // заполнение параметров
				// TODO: сократить код по возможности
                command_q1.Parameters.AddWithValue("@date1", new DateTime(Convert.ToInt32(mtxtReport3_Year.Text), 1, 1));
                command_q1.Parameters.AddWithValue("@date2", new DateTime(Convert.ToInt32(mtxtReport3_Year.Text), 4, 1));
                command_q2.Parameters.AddWithValue("@date1", new DateTime(Convert.ToInt32(mtxtReport3_Year.Text), 4, 1));
                command_q2.Parameters.AddWithValue("@date2", new DateTime(Convert.ToInt32(mtxtReport3_Year.Text), 7, 1));
                command_q3.Parameters.AddWithValue("@date1", new DateTime(Convert.ToInt32(mtxtReport3_Year.Text), 7, 1));
                command_q3.Parameters.AddWithValue("@date2", new DateTime(Convert.ToInt32(mtxtReport3_Year.Text), 10, 1));
                command_q4.Parameters.AddWithValue("@date1", new DateTime(Convert.ToInt32(mtxtReport3_Year.Text), 10, 1));
                command_q4.Parameters.AddWithValue("@date2", new DateTime(Convert.ToInt32(mtxtReport3_Year.Text) + 1, 1, 1));

                // отправка запросов
                DataTable queryResult_q1 = conn.SqlGetRows_Implicit(command_q1);
                DataTable queryResult_q2 = conn.SqlGetRows_Implicit(command_q2);
                DataTable queryResult_q3 = conn.SqlGetRows_Implicit(command_q3);
                DataTable queryResult_q4 = conn.SqlGetRows_Implicit(command_q4);
                
                if (queryResult_q1 == null || queryResult_q2 == null || queryResult_q3 == null || queryResult_q4 == null)
                {
                    MessageBox.Show(this, "Не удалось извлечь данные из БД!", "Прибыль/убыль -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // вывод результатов запросов на экран
                SetValues(queryResult_q1, lblReport3_q1_1_Value, lblReport3_q1_2_Value, lblReport3_q1_3_Value, lblReport3_q1_4_Value);
                SetValues(queryResult_q2, lblReport3_q2_1_Value, lblReport3_q2_2_Value, lblReport3_q2_3_Value, lblReport3_q2_4_Value);
                SetValues(queryResult_q3, lblReport3_q3_1_Value, lblReport3_q3_2_Value, lblReport3_q3_3_Value, lblReport3_q3_4_Value);
                SetValues(queryResult_q4, lblReport3_q4_1_Value, lblReport3_q4_2_Value, lblReport3_q4_3_Value, lblReport3_q4_4_Value);

                // расчёт прибыли/убыли
                CalcFunctions(queryResult_q1, txtReport3_q1_F1, txtReport3_q1_F2);
                CalcFunctions(queryResult_q2, txtReport3_q2_F1, txtReport3_q2_F2);
                CalcFunctions(queryResult_q3, txtReport3_q3_F1, txtReport3_q3_F2);
                CalcFunctions(queryResult_q4, txtReport3_q4_F1, txtReport3_q4_F2);
            }
        }

        //--------------------------------------------------------------
        // Отчёты -> флаг "По департаментам", переключает отчёты 1 и 2
        //--------------------------------------------------------------
        private void chkReportSplitDepts_CheckedChanged(object sender, EventArgs e)
        {
            cmbReportType_SelectedIndexChanged(sender, e);
        }

        //--------------------------------------------------------------
        // Отчёты -> выбор Организации
        //--------------------------------------------------------------
        private void cmbReportOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbReportType_SelectedIndexChanged(sender, e);
        }

        //--------------------------------------------------------------
        // Отчёты -> Отчёт 3 "прибыль/убыль" -> кнопка Применить
        //--------------------------------------------------------------
        private void btnReport3_Apply_Click(object sender, EventArgs e)
        {
            cmbReportType_SelectedIndexChanged(sender, e);
        }

        //--------------------------------------------------------------
        // Отчёты -> Отчёт 3 "прибыль/убыль" -> фильтр Год -- нажатие Enter
        //--------------------------------------------------------------
        private void mtxtReport3_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter -> btnReport3_Apply
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnReport3_Apply_Click(null, null);
            }
        }
    }
}

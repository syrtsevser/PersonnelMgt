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
    public partial class FormSelectRoom : Form
    {
        ConnDB conn = ConnDB.Instance;
        List<CommonFuncs.ListBoxValues> listTrackedOrgs = new List<CommonFuncs.ListBoxValues>();

        public FormSelectRoom(int? selectedOrgID = null)
        {
            InitializeComponent();
            dgvRooms.AutoGenerateColumns = false;

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
            dgvRooms.DataSource = null;

            if (cmbOrg.SelectedIndex < 0)
                return;

            // заполнить список "Помещения"
            int selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;
            string query = string.Format(@"SELECT id_room, number, max_workplaces FROM rooms WHERE id_org = {0}", selectedOrgID);

            // TODO: добавить генерируемое поле "свободных мест"

            DataTable dataTable = conn.SqlGetRows(query);
            dgvRooms.DataSource = dataTable;
        }

        //--------------------------------------------------------------
        // Кнопка "Отменить"
        //--------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------------------------------------------
        // Кнопка "Выбрать"
        //--------------------------------------------------------------
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cmbOrg.SelectedIndex < 0 || dgvRooms.DataSource == null || dgvRooms.SelectedCells.Count == 0)
                return;

            //int selectedRoomID = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["dgvcRoomId"].Value);
            
            if (Owner != null)
            {
                // форма "Добавить сотрудника"
                if (Owner.GetType() == typeof(FormAddPerson))
                {
                    // поле "Организация"
                    ComboBox cmbOrg_owner = (Owner as FormAddPerson).Controls["cmbOrg"] as ComboBox;
                    cmbOrg_owner.SelectedValue = cmbOrg.SelectedValue;
                    (this.Owner as FormAddPerson).cmbOrg_SelectedIndexChanged(null, null);

                    // поле "Департамент"
                    // TODO: сохранить предыдущее значение поля ДЕПАРТАМЕНТ и присвоить его. сейчас оно сбрасывается.

                    // поле "Помещение"
                    ComboBox cmbRoom_owner = (Owner as FormAddPerson).Controls["cmbRoom"] as ComboBox;
                    cmbRoom_owner.SelectedIndex = cmbRoom_owner.FindStringExact(dgvRooms.SelectedRows[0].Cells["dgvcRoomNumber"].Value.ToString());
                }
            }
            this.Close();
        }

        //--------------------------------------------------------------
        // Список "помещения" -> двойной клик по помещению
        //--------------------------------------------------------------
        private void dgvRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAccept_Click(sender, e);
        }

        //--------------------------------------------------------------
        // Список "помещения" -> кнопка "[+] добавить"
        //--------------------------------------------------------------
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (cmbOrg.DataSource == null || cmbOrg.Items.Count == 0 || cmbOrg.SelectedIndex == -1)
                return;

            if (Application.OpenForms["FormAddRoom"] as FormAddRoom == null)
            {
                int selectedOrgID = (cmbOrg.SelectedItem as CommonFuncs.ListBoxValues).Value;
                FormAddRoom formNewRoom = new FormAddRoom(selectedOrgID);
                formNewRoom.Owner = this;
                formNewRoom.ShowDialog();
            }
            else
            {
                Application.OpenForms["FormAddRoom"].BringToFront();
            }
        }

        //--------------------------------------------------------------
        // Список "помещения" -> кнопка "[-] удалить"
        //--------------------------------------------------------------
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (cmbOrg.DataSource == null || cmbOrg.SelectedIndex == -1 || dgvRooms.DataSource == null || dgvRooms.SelectedRows.Count == 0)
                return;

            int selectedRoomId = -1;
            string selectedRoomNumber = "";
            try
            {
                selectedRoomId = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["dgvcRoomId"].Value);
                selectedRoomNumber = dgvRooms.SelectedRows[0].Cells["dgvcRoomNumber"].Value.ToString();
            }
            catch (Exception)
            {
                string msgText  = "Не удалось удалить помещение! \n\nПричина: не удалось получить ID выделенного помещения.";
                MessageBox.Show(this, msgText, "Удалить помещение -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // диалог
            string message = string.Format("Удалить помещение {0}?", selectedRoomNumber);
            DialogResult reply = MessageBox.Show(this, message, "Удалить", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (reply == DialogResult.Cancel)
                return;

            // удаление помещения из базы
            string query = @"DELETE FROM rooms WHERE id_room = @id";
            var command = new NpgsqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", selectedRoomId);

            if (!conn.SqlExecuteNonQuery_Implicit(command))
            {
                MessageBox.Show(this, "Не удалось удалить помещение!", "Удалить помещение -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*
            // запрос в бд (старый код)
            var cf = new CommonFuncs();
            var listParams = new List<CommonFuncs.SqlColumnAndParam>();
            var listQueriesQueue = new List<CommonFuncs.SqlQueryAndParams>();

            string query = @"DELETE FROM rooms WHERE id_room = :p0";
            cf.AddTupleToList(ref listParams, "id_room", selectedRoomId);
            listQueriesQueue.Add(new CommonFuncs.SqlQueryAndParams(query, listParams));

            if (!conn.SqlExecuteNonQuery_Consecutively(listQueriesQueue))
            {
                MessageBox.Show(this, "Не удалось удалить помещение!", "Удалить помещение -- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */

            // обновление перечня помещений в "Выбрать помещение"
            cmbOrg_SelectedIndexChanged(null, null);

            // обновление перечня помещений в других формах
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

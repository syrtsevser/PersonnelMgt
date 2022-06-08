using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelMgt
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------
        // Выход
        //--------------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--------------------------------------------------------------
        // Запуск
        //--------------------------------------------------------------
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Укажите пользователя!");
                txtUser.Focus();
                return;
            }

            ConnDB conn = ConnDB.Instance;
            conn.SetParams(txtUser.Text, txtPass.Text);

            if (conn.AttemptAuth())
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Не удалось подключиться к серверу!");
                txtUser.Focus();
                return;
            }
        }

        //--------------------------------------------------------------
        // Параметры
        //--------------------------------------------------------------
        private void btnParameters_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();
        }

        //--------------------------------------------------------------
        // Горячие клавишы
        //--------------------------------------------------------------
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Enter -> btnStart
            if (keyData == (Keys.Enter))
            {
                btnStart_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

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
    public partial class FormSettings : Form
    {
        IniSettings ini = new IniSettings();

        public FormSettings()
        {
            InitializeComponent();
            GetIniParams();
        }

        //--------------------------------------------------------------
        // GetIniParams -- считывание данных из INI
        //--------------------------------------------------------------
        private void GetIniParams()
        {
            if (ini.KeyExists("DbAddress"))
                txtDbAddress.Text = ini.Read("DbAddress");

            if (ini.KeyExists("DbName"))
                txtDbName.Text = ini.Read("DbName");
        }

        //--------------------------------------------------------------
        // Кнопка "Применить"
        //--------------------------------------------------------------
        private void btnApply_Click(object sender, EventArgs e)
        {
            ini.Write("DbAddress", txtDbAddress.Text);
            ini.Write("DbName", txtDbName.Text);

            this.Close();
        }

        //--------------------------------------------------------------
        // Кнопка "Сбросить изменения"
        //--------------------------------------------------------------
        private void btnReset_Click(object sender, EventArgs e)
        {
            // TODO: реализовать код
            //
        }
    }
}

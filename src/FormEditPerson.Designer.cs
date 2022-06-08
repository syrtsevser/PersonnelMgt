
namespace PersonnelMgt
{
    partial class FormEditPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.dtpDateHired = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateDismissed = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOtherContacts = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.cmbOrg = new System.Windows.Forms.ComboBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.btnSelectDept = new System.Windows.Forms.Button();
            this.btnSelectOrg = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.dgvcHistoryIdEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcHistoryDateHired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcHistoryDateDismissed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsHistory = new System.Windows.Forms.ToolStrip();
            this.tsBtnRemoveHistory = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.numericHoursWeek = new System.Windows.Forms.NumericUpDown();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.tsHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoursWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(117, 21);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(214, 22);
            this.txtLastName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(117, 49);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(214, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddleName.Location = new System.Drawing.Point(117, 77);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(214, 22);
            this.txtMiddleName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Организация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Департамент";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата рождения";
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.Checked = false;
            this.dtpDateBirth.CustomFormat = "dd.MM.yyyy";
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBirth.Location = new System.Drawing.Point(117, 105);
            this.dtpDateBirth.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpDateBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.ShowCheckBox = true;
            this.dtpDateBirth.Size = new System.Drawing.Size(158, 22);
            this.dtpDateBirth.TabIndex = 3;
            // 
            // dtpDateHired
            // 
            this.dtpDateHired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateHired.CustomFormat = "dd.MM.yyyy";
            this.dtpDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateHired.Location = new System.Drawing.Point(465, 301);
            this.dtpDateHired.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpDateHired.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateHired.Name = "dtpDateHired";
            this.dtpDateHired.ShowCheckBox = true;
            this.dtpDateHired.Size = new System.Drawing.Size(158, 22);
            this.dtpDateHired.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Принят";
            // 
            // dtpDateDismissed
            // 
            this.dtpDateDismissed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateDismissed.Checked = false;
            this.dtpDateDismissed.CustomFormat = "dd.MM.yyyy";
            this.dtpDateDismissed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDismissed.Location = new System.Drawing.Point(465, 329);
            this.dtpDateDismissed.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpDateDismissed.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateDismissed.Name = "dtpDateDismissed";
            this.dtpDateDismissed.ShowCheckBox = true;
            this.dtpDateDismissed.Size = new System.Drawing.Size(158, 22);
            this.dtpDateDismissed.TabIndex = 18;
            this.dtpDateDismissed.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Уволен";
            // 
            // txtOtherContacts
            // 
            this.txtOtherContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherContacts.Location = new System.Drawing.Point(117, 359);
            this.txtOtherContacts.Multiline = true;
            this.txtOtherContacts.Name = "txtOtherContacts";
            this.txtOtherContacts.Size = new System.Drawing.Size(214, 45);
            this.txtOtherContacts.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 32);
            this.label10.TabIndex = 27;
            this.label10.Text = "Другая \r\nсвязь\r\n";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(117, 331);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Почта";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Телефон";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(117, 421);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(556, 55);
            this.txtComment.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 424);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Комментарий";
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosition.Location = new System.Drawing.Point(117, 233);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(214, 22);
            this.txtPosition.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Помещение";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Часы / неделя";
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtPhone.Location = new System.Drawing.Point(117, 303);
            this.mtxtPhone.Mask = "#9 (999) 900 - 0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(214, 22);
            this.mtxtPhone.TabIndex = 12;
            this.mtxtPhone.Text = "+7";
            this.mtxtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbOrg
            // 
            this.cmbOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrg.FormattingEnabled = true;
            this.cmbOrg.Location = new System.Drawing.Point(117, 149);
            this.cmbOrg.Name = "cmbOrg";
            this.cmbOrg.Size = new System.Drawing.Size(214, 24);
            this.cmbOrg.TabIndex = 4;
            this.cmbOrg.SelectedIndexChanged += new System.EventHandler(this.cmbOrg_SelectedIndexChanged);
            // 
            // cmbDept
            // 
            this.cmbDept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(117, 177);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(214, 24);
            this.cmbDept.TabIndex = 6;
            // 
            // cmbRoom
            // 
            this.cmbRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(117, 205);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(214, 24);
            this.cmbRoom.TabIndex = 8;
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectRoom.Enabled = false;
            this.btnSelectRoom.Image = global::PersonnelMgt.Properties.Resources.Edit_16x;
            this.btnSelectRoom.Location = new System.Drawing.Point(342, 205);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(25, 23);
            this.btnSelectRoom.TabIndex = 9;
            this.toolTips.SetToolTip(this.btnSelectRoom, "Выбрать");
            this.btnSelectRoom.UseVisualStyleBackColor = true;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // btnSelectDept
            // 
            this.btnSelectDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDept.Enabled = false;
            this.btnSelectDept.Image = global::PersonnelMgt.Properties.Resources.Edit_16x;
            this.btnSelectDept.Location = new System.Drawing.Point(342, 177);
            this.btnSelectDept.Name = "btnSelectDept";
            this.btnSelectDept.Size = new System.Drawing.Size(25, 23);
            this.btnSelectDept.TabIndex = 7;
            this.toolTips.SetToolTip(this.btnSelectDept, "Выбрать");
            this.btnSelectDept.UseVisualStyleBackColor = true;
            this.btnSelectDept.Click += new System.EventHandler(this.btnSelectDept_Click);
            // 
            // btnSelectOrg
            // 
            this.btnSelectOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectOrg.Enabled = false;
            this.btnSelectOrg.Image = global::PersonnelMgt.Properties.Resources.Edit_16x;
            this.btnSelectOrg.Location = new System.Drawing.Point(342, 149);
            this.btnSelectOrg.Name = "btnSelectOrg";
            this.btnSelectOrg.Size = new System.Drawing.Size(25, 23);
            this.btnSelectOrg.TabIndex = 5;
            this.toolTips.SetToolTip(this.btnSelectOrg, "Выбрать");
            this.btnSelectOrg.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(391, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 16);
            this.label16.TabIndex = 51;
            this.label16.Text = "История работы:";
            // 
            // panelHistory
            // 
            this.panelHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistory.Controls.Add(this.dgvHistory);
            this.panelHistory.Controls.Add(this.tsHistory);
            this.panelHistory.Location = new System.Drawing.Point(391, 49);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(280, 234);
            this.panelHistory.TabIndex = 52;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcHistoryIdEmployee,
            this.dgvcHistoryDateHired,
            this.dgvcHistoryDateDismissed});
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 25);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(278, 207);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.SelectionChanged += new System.EventHandler(this.dgvHistory_SelectionChanged);
            // 
            // dgvcHistoryIdEmployee
            // 
            this.dgvcHistoryIdEmployee.DataPropertyName = "id_employee";
            this.dgvcHistoryIdEmployee.HeaderText = "ID_EMPLOYEE";
            this.dgvcHistoryIdEmployee.Name = "dgvcHistoryIdEmployee";
            this.dgvcHistoryIdEmployee.ReadOnly = true;
            this.dgvcHistoryIdEmployee.Visible = false;
            // 
            // dgvcHistoryDateHired
            // 
            this.dgvcHistoryDateHired.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcHistoryDateHired.DataPropertyName = "date_hired";
            this.dgvcHistoryDateHired.HeaderText = "Принят";
            this.dgvcHistoryDateHired.Name = "dgvcHistoryDateHired";
            this.dgvcHistoryDateHired.ReadOnly = true;
            // 
            // dgvcHistoryDateDismissed
            // 
            this.dgvcHistoryDateDismissed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcHistoryDateDismissed.DataPropertyName = "date_dismissed";
            this.dgvcHistoryDateDismissed.HeaderText = "Уволен";
            this.dgvcHistoryDateDismissed.Name = "dgvcHistoryDateDismissed";
            this.dgvcHistoryDateDismissed.ReadOnly = true;
            // 
            // tsHistory
            // 
            this.tsHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnRemoveHistory,
            this.toolStripLabel1});
            this.tsHistory.Location = new System.Drawing.Point(0, 0);
            this.tsHistory.Name = "tsHistory";
            this.tsHistory.Size = new System.Drawing.Size(278, 25);
            this.tsHistory.TabIndex = 1;
            // 
            // tsBtnRemoveHistory
            // 
            this.tsBtnRemoveHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRemoveHistory.Image = global::PersonnelMgt.Properties.Resources.Remove_color_16x;
            this.tsBtnRemoveHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRemoveHistory.Name = "tsBtnRemoveHistory";
            this.tsBtnRemoveHistory.Size = new System.Drawing.Size(23, 22);
            this.tsBtnRemoveHistory.Text = "Стереть";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::PersonnelMgt.Properties.Resources.Cancel_16x;
            this.btnCancel.Location = new System.Drawing.Point(432, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 31);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Image = global::PersonnelMgt.Properties.Resources.Checkmark_16x;
            this.btnAccept.Location = new System.Drawing.Point(560, 493);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(113, 31);
            this.btnAccept.TabIndex = 19;
            this.btnAccept.Text = "Применить";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // numericHoursWeek
            // 
            this.numericHoursWeek.Location = new System.Drawing.Point(117, 260);
            this.numericHoursWeek.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericHoursWeek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericHoursWeek.Name = "numericHoursWeek";
            this.numericHoursWeek.Size = new System.Drawing.Size(65, 22);
            this.numericHoursWeek.TabIndex = 11;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(183, 22);
            this.toolStripLabel1.Text = "<Данная строка тут временно.>";
            // 
            // FormEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 543);
            this.Controls.Add(this.numericHoursWeek);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.cmbOrg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnSelectRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtOtherContacts);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDateDismissed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDateHired);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDateBirth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelectDept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSelectOrg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактировать сотрудника";
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.tsHistory.ResumeLayout(false);
            this.tsHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoursWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectOrg;
        private System.Windows.Forms.Button btnSelectDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.DateTimePicker dtpDateHired;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateDismissed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOtherContacts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSelectRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbOrg;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.ToolStrip tsHistory;
        private System.Windows.Forms.ToolStripButton tsBtnRemoveHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.NumericUpDown numericHoursWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHistoryIdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHistoryDateHired;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHistoryDateDismissed;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}
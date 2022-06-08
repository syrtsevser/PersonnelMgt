
namespace PersonnelMgt
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagePersonnel = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPersonnelTable = new System.Windows.Forms.DataGridView();
            this.dgvcEmployeesIdPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesIdEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesRoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesHardware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesKeys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesHoursWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesDateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesContactEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesContactOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesNameFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesNameLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesNameFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesNameMiddle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesDateHired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEmployeesDateDismissed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlPersonnel = new System.Windows.Forms.TabControl();
            this.tabPageEmployee1 = new System.Windows.Forms.TabPage();
            this.txtPrsDateDismissed = new System.Windows.Forms.TextBox();
            this.txtPrsDateHired = new System.Windows.Forms.TextBox();
            this.txtPrsDateBirth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrsContactOther = new System.Windows.Forms.TextBox();
            this.txtPrsContactEmail = new System.Windows.Forms.TextBox();
            this.txtPrsContactPhone = new System.Windows.Forms.TextBox();
            this.txtPrsHoursWeek = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrsRoomNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrsPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrsFullName1 = new System.Windows.Forms.TextBox();
            this.tabPageEmployee2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrsFullName2 = new System.Windows.Forms.TextBox();
            this.tabPageEmployee3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrsFullName3 = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsBtnPrsnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrsnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnPrsnDismiss = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnPrsnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnPrsnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrsnToggleConcurrent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tabPageReports1 = new System.Windows.Forms.TabPage();
            this.dgvReport1 = new System.Windows.Forms.DataGridView();
            this.dgvcReport1_IdEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcReport1_RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcReport1_NameFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcReport1_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcReport1_DateHired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageReports2 = new System.Windows.Forms.TabPage();
            this.dgvReport2 = new System.Windows.Forms.DataGridView();
            this.dgvcReport2_IdEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcReport2_IdDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcReport2_RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcReport2_DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcReport2_NameFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcvReport2_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcReport2_DateHired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageReports3 = new System.Windows.Forms.TabPage();
            this.txtReport3_q1_F2 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtReport3_q1_F1 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtReport3_q4_F2 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtReport3_q4_F1 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtReport3_q3_F2 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtReport3_q3_F1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtReport3_q2_F2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtReport3_q2_F1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblReport3_q4_4_Value = new System.Windows.Forms.Label();
            this.lblReport3_q4_3_Value = new System.Windows.Forms.Label();
            this.lblReport3_q4_2_Value = new System.Windows.Forms.Label();
            this.lblReport3_q4_1_Value = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblReport3_q3_4_Value = new System.Windows.Forms.Label();
            this.lblReport3_q3_3_Value = new System.Windows.Forms.Label();
            this.lblReport3_q3_2_Value = new System.Windows.Forms.Label();
            this.lblReport3_q3_1_Value = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.lblReport3_q2_4_Value = new System.Windows.Forms.Label();
            this.lblReport3_q2_3_Value = new System.Windows.Forms.Label();
            this.lblReport3_q2_2_Value = new System.Windows.Forms.Label();
            this.lblReport3_q2_1_Value = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblReport3_q1_4_Value = new System.Windows.Forms.Label();
            this.lblReport3_q1_3_Value = new System.Windows.Forms.Label();
            this.lblReport3_q1_2_Value = new System.Windows.Forms.Label();
            this.lblReport3_q1_1_Value = new System.Windows.Forms.Label();
            this.lblReport3_q1_4 = new System.Windows.Forms.Label();
            this.lblReport3_q1_3 = new System.Windows.Forms.Label();
            this.lblReport3_q1_2 = new System.Windows.Forms.Label();
            this.lblReport3_q1_1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReport3_Apply = new System.Windows.Forms.Button();
            this.mtxtReport3_Year = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkReportSplitDepts = new System.Windows.Forms.CheckBox();
            this.cmbReportOrg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageDepts = new System.Windows.Forms.TabPage();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.tabPageHardware = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnPersonnel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnReports = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnDepts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnRooms = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnHardware = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnApplicants = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLabelNotifications = new System.Windows.Forms.ToolStripLabel();
            this.tsDropBtnNotifications = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnInterviews = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPagePersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnelTable)).BeginInit();
            this.tabControlPersonnel.SuspendLayout();
            this.tabPageEmployee1.SuspendLayout();
            this.tabPageEmployee2.SuspendLayout();
            this.tabPageEmployee3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPageReports.SuspendLayout();
            this.tabControlReports.SuspendLayout();
            this.tabPageReports1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).BeginInit();
            this.tabPageReports2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport2)).BeginInit();
            this.tabPageReports3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings,
            this.tsmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(134, 22);
            this.tsmiSettings.Text = "Настройки";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(134, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(149, 22);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagePersonnel);
            this.tabControlMain.Controls.Add(this.tabPageReports);
            this.tabControlMain.Controls.Add(this.tabPageDepts);
            this.tabControlMain.Controls.Add(this.tabPageRooms);
            this.tabControlMain.Controls.Add(this.tabPageHardware);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.Location = new System.Drawing.Point(80, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1050, 578);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabPagePersonnel
            // 
            this.tabPagePersonnel.Controls.Add(this.splitContainer1);
            this.tabPagePersonnel.Controls.Add(this.toolStrip2);
            this.tabPagePersonnel.Location = new System.Drawing.Point(4, 25);
            this.tabPagePersonnel.Name = "tabPagePersonnel";
            this.tabPagePersonnel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonnel.Size = new System.Drawing.Size(1042, 549);
            this.tabPagePersonnel.TabIndex = 0;
            this.tabPagePersonnel.Text = "Сотрудники";
            this.tabPagePersonnel.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.dgvPersonnelTable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.tabControlPersonnel);
            this.splitContainer1.Size = new System.Drawing.Size(1036, 518);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 9;
            this.splitContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseDown);
            this.splitContainer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseUp);
            // 
            // dgvPersonnelTable
            // 
            this.dgvPersonnelTable.AllowUserToAddRows = false;
            this.dgvPersonnelTable.AllowUserToDeleteRows = false;
            this.dgvPersonnelTable.AllowUserToResizeRows = false;
            this.dgvPersonnelTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPersonnelTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnelTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcEmployeesIdPerson,
            this.dgvcEmployeesIdEmployee,
            this.dgvcEmployeesName,
            this.dgvcEmployeesDept,
            this.dgvcEmployeesPosition,
            this.dgvcEmployeesRoomNum,
            this.dgvcEmployeesHardware,
            this.dgvcEmployeesKeys,
            this.dgvcEmployeesHoursWeek,
            this.dgvcEmployeesDateBirth,
            this.dgvcEmployeesContactPhone,
            this.dgvcEmployeesContactEmail,
            this.dgvcEmployeesContactOther,
            this.dgvcEmployeesNameFull,
            this.dgvcEmployeesNameLast,
            this.dgvcEmployeesNameFirst,
            this.dgvcEmployeesNameMiddle,
            this.dgvcEmployeesDateHired,
            this.dgvcEmployeesDateDismissed});
            this.dgvPersonnelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonnelTable.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonnelTable.MultiSelect = false;
            this.dgvPersonnelTable.Name = "dgvPersonnelTable";
            this.dgvPersonnelTable.ReadOnly = true;
            this.dgvPersonnelTable.RowHeadersVisible = false;
            this.dgvPersonnelTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPersonnelTable.RowTemplate.Height = 25;
            this.dgvPersonnelTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonnelTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnelTable.Size = new System.Drawing.Size(1036, 346);
            this.dgvPersonnelTable.TabIndex = 0;
            this.dgvPersonnelTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnelTable_CellDoubleClick);
            this.dgvPersonnelTable.SelectionChanged += new System.EventHandler(this.dgvPersonnelTable_SelectionChanged);
            // 
            // dgvcEmployeesIdPerson
            // 
            this.dgvcEmployeesIdPerson.DataPropertyName = "id_person";
            this.dgvcEmployeesIdPerson.HeaderText = "ID_PERSON";
            this.dgvcEmployeesIdPerson.Name = "dgvcEmployeesIdPerson";
            this.dgvcEmployeesIdPerson.ReadOnly = true;
            this.dgvcEmployeesIdPerson.Visible = false;
            this.dgvcEmployeesIdPerson.Width = 88;
            // 
            // dgvcEmployeesIdEmployee
            // 
            this.dgvcEmployeesIdEmployee.DataPropertyName = "id_employee";
            this.dgvcEmployeesIdEmployee.HeaderText = "ID_EMPLOYEE";
            this.dgvcEmployeesIdEmployee.Name = "dgvcEmployeesIdEmployee";
            this.dgvcEmployeesIdEmployee.ReadOnly = true;
            this.dgvcEmployeesIdEmployee.Visible = false;
            this.dgvcEmployeesIdEmployee.Width = 106;
            // 
            // dgvcEmployeesName
            // 
            this.dgvcEmployeesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcEmployeesName.DataPropertyName = "name";
            this.dgvcEmployeesName.HeaderText = "Имя";
            this.dgvcEmployeesName.MinimumWidth = 170;
            this.dgvcEmployeesName.Name = "dgvcEmployeesName";
            this.dgvcEmployeesName.ReadOnly = true;
            // 
            // dgvcEmployeesDept
            // 
            this.dgvcEmployeesDept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvcEmployeesDept.DataPropertyName = "dept_name";
            this.dgvcEmployeesDept.HeaderText = "Департамент";
            this.dgvcEmployeesDept.MinimumWidth = 140;
            this.dgvcEmployeesDept.Name = "dgvcEmployeesDept";
            this.dgvcEmployeesDept.ReadOnly = true;
            this.dgvcEmployeesDept.Width = 140;
            // 
            // dgvcEmployeesPosition
            // 
            this.dgvcEmployeesPosition.DataPropertyName = "position";
            this.dgvcEmployeesPosition.HeaderText = "Должность";
            this.dgvcEmployeesPosition.MinimumWidth = 130;
            this.dgvcEmployeesPosition.Name = "dgvcEmployeesPosition";
            this.dgvcEmployeesPosition.ReadOnly = true;
            this.dgvcEmployeesPosition.Width = 130;
            // 
            // dgvcEmployeesRoomNum
            // 
            this.dgvcEmployeesRoomNum.DataPropertyName = "room_number";
            this.dgvcEmployeesRoomNum.HeaderText = "Помещение";
            this.dgvcEmployeesRoomNum.MinimumWidth = 30;
            this.dgvcEmployeesRoomNum.Name = "dgvcEmployeesRoomNum";
            this.dgvcEmployeesRoomNum.ReadOnly = true;
            this.dgvcEmployeesRoomNum.Width = 105;
            // 
            // dgvcEmployeesHardware
            // 
            this.dgvcEmployeesHardware.DataPropertyName = "hardware_cnt";
            this.dgvcEmployeesHardware.HeaderText = "Техника";
            this.dgvcEmployeesHardware.MinimumWidth = 80;
            this.dgvcEmployeesHardware.Name = "dgvcEmployeesHardware";
            this.dgvcEmployeesHardware.ReadOnly = true;
            this.dgvcEmployeesHardware.Width = 80;
            // 
            // dgvcEmployeesKeys
            // 
            this.dgvcEmployeesKeys.DataPropertyName = "keys_cnt";
            this.dgvcEmployeesKeys.HeaderText = "Ключи";
            this.dgvcEmployeesKeys.MinimumWidth = 80;
            this.dgvcEmployeesKeys.Name = "dgvcEmployeesKeys";
            this.dgvcEmployeesKeys.ReadOnly = true;
            this.dgvcEmployeesKeys.Width = 80;
            // 
            // dgvcEmployeesHoursWeek
            // 
            this.dgvcEmployeesHoursWeek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcEmployeesHoursWeek.DataPropertyName = "hours_week";
            this.dgvcEmployeesHoursWeek.HeaderText = "Часов/неделю";
            this.dgvcEmployeesHoursWeek.MinimumWidth = 30;
            this.dgvcEmployeesHoursWeek.Name = "dgvcEmployeesHoursWeek";
            this.dgvcEmployeesHoursWeek.ReadOnly = true;
            this.dgvcEmployeesHoursWeek.Width = 108;
            // 
            // dgvcEmployeesDateBirth
            // 
            this.dgvcEmployeesDateBirth.DataPropertyName = "date_birth";
            this.dgvcEmployeesDateBirth.HeaderText = "Дата рождения";
            this.dgvcEmployeesDateBirth.Name = "dgvcEmployeesDateBirth";
            this.dgvcEmployeesDateBirth.ReadOnly = true;
            this.dgvcEmployeesDateBirth.Visible = false;
            this.dgvcEmployeesDateBirth.Width = 124;
            // 
            // dgvcEmployeesContactPhone
            // 
            this.dgvcEmployeesContactPhone.DataPropertyName = "contact_phone";
            this.dgvcEmployeesContactPhone.HeaderText = "Телефон";
            this.dgvcEmployeesContactPhone.Name = "dgvcEmployeesContactPhone";
            this.dgvcEmployeesContactPhone.ReadOnly = true;
            this.dgvcEmployeesContactPhone.Visible = false;
            this.dgvcEmployeesContactPhone.Width = 83;
            // 
            // dgvcEmployeesContactEmail
            // 
            this.dgvcEmployeesContactEmail.DataPropertyName = "contact_email";
            this.dgvcEmployeesContactEmail.HeaderText = "Почта";
            this.dgvcEmployeesContactEmail.Name = "dgvcEmployeesContactEmail";
            this.dgvcEmployeesContactEmail.ReadOnly = true;
            this.dgvcEmployeesContactEmail.Visible = false;
            this.dgvcEmployeesContactEmail.Width = 68;
            // 
            // dgvcEmployeesContactOther
            // 
            this.dgvcEmployeesContactOther.DataPropertyName = "contact_other";
            this.dgvcEmployeesContactOther.HeaderText = "Другая связь";
            this.dgvcEmployeesContactOther.Name = "dgvcEmployeesContactOther";
            this.dgvcEmployeesContactOther.ReadOnly = true;
            this.dgvcEmployeesContactOther.Visible = false;
            this.dgvcEmployeesContactOther.Width = 113;
            // 
            // dgvcEmployeesNameFull
            // 
            this.dgvcEmployeesNameFull.DataPropertyName = "name_full";
            this.dgvcEmployeesNameFull.HeaderText = "ФИО";
            this.dgvcEmployeesNameFull.Name = "dgvcEmployeesNameFull";
            this.dgvcEmployeesNameFull.ReadOnly = true;
            this.dgvcEmployeesNameFull.Visible = false;
            this.dgvcEmployeesNameFull.Width = 63;
            // 
            // dgvcEmployeesNameLast
            // 
            this.dgvcEmployeesNameLast.DataPropertyName = "name_last";
            this.dgvcEmployeesNameLast.HeaderText = "Фамилия";
            this.dgvcEmployeesNameLast.Name = "dgvcEmployeesNameLast";
            this.dgvcEmployeesNameLast.ReadOnly = true;
            this.dgvcEmployeesNameLast.Visible = false;
            this.dgvcEmployeesNameLast.Width = 88;
            // 
            // dgvcEmployeesNameFirst
            // 
            this.dgvcEmployeesNameFirst.DataPropertyName = "name_first";
            this.dgvcEmployeesNameFirst.HeaderText = "Имя";
            this.dgvcEmployeesNameFirst.Name = "dgvcEmployeesNameFirst";
            this.dgvcEmployeesNameFirst.ReadOnly = true;
            this.dgvcEmployeesNameFirst.Visible = false;
            this.dgvcEmployeesNameFirst.Width = 58;
            // 
            // dgvcEmployeesNameMiddle
            // 
            this.dgvcEmployeesNameMiddle.DataPropertyName = "name_middle";
            this.dgvcEmployeesNameMiddle.HeaderText = "Отчество";
            this.dgvcEmployeesNameMiddle.Name = "dgvcEmployeesNameMiddle";
            this.dgvcEmployeesNameMiddle.ReadOnly = true;
            this.dgvcEmployeesNameMiddle.Visible = false;
            this.dgvcEmployeesNameMiddle.Width = 88;
            // 
            // dgvcEmployeesDateHired
            // 
            this.dgvcEmployeesDateHired.DataPropertyName = "date_hired";
            this.dgvcEmployeesDateHired.HeaderText = "Принят";
            this.dgvcEmployeesDateHired.MinimumWidth = 82;
            this.dgvcEmployeesDateHired.Name = "dgvcEmployeesDateHired";
            this.dgvcEmployeesDateHired.ReadOnly = true;
            this.dgvcEmployeesDateHired.Width = 82;
            // 
            // dgvcEmployeesDateDismissed
            // 
            this.dgvcEmployeesDateDismissed.DataPropertyName = "date_dismissed";
            this.dgvcEmployeesDateDismissed.HeaderText = "Уволен";
            this.dgvcEmployeesDateDismissed.MinimumWidth = 82;
            this.dgvcEmployeesDateDismissed.Name = "dgvcEmployeesDateDismissed";
            this.dgvcEmployeesDateDismissed.ReadOnly = true;
            this.dgvcEmployeesDateDismissed.Width = 82;
            // 
            // tabControlPersonnel
            // 
            this.tabControlPersonnel.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlPersonnel.Controls.Add(this.tabPageEmployee1);
            this.tabControlPersonnel.Controls.Add(this.tabPageEmployee2);
            this.tabControlPersonnel.Controls.Add(this.tabPageEmployee3);
            this.tabControlPersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPersonnel.Location = new System.Drawing.Point(0, 0);
            this.tabControlPersonnel.Multiline = true;
            this.tabControlPersonnel.Name = "tabControlPersonnel";
            this.tabControlPersonnel.Padding = new System.Drawing.Point(10, 8);
            this.tabControlPersonnel.SelectedIndex = 0;
            this.tabControlPersonnel.Size = new System.Drawing.Size(1036, 168);
            this.tabControlPersonnel.TabIndex = 6;
            // 
            // tabPageEmployee1
            // 
            this.tabPageEmployee1.Controls.Add(this.txtPrsDateDismissed);
            this.tabPageEmployee1.Controls.Add(this.txtPrsDateHired);
            this.tabPageEmployee1.Controls.Add(this.txtPrsDateBirth);
            this.tabPageEmployee1.Controls.Add(this.label10);
            this.tabPageEmployee1.Controls.Add(this.label11);
            this.tabPageEmployee1.Controls.Add(this.label14);
            this.tabPageEmployee1.Controls.Add(this.txtPrsContactOther);
            this.tabPageEmployee1.Controls.Add(this.txtPrsContactEmail);
            this.tabPageEmployee1.Controls.Add(this.txtPrsContactPhone);
            this.tabPageEmployee1.Controls.Add(this.txtPrsHoursWeek);
            this.tabPageEmployee1.Controls.Add(this.label13);
            this.tabPageEmployee1.Controls.Add(this.txtPrsRoomNum);
            this.tabPageEmployee1.Controls.Add(this.label12);
            this.tabPageEmployee1.Controls.Add(this.label9);
            this.tabPageEmployee1.Controls.Add(this.txtPrsPosition);
            this.tabPageEmployee1.Controls.Add(this.label8);
            this.tabPageEmployee1.Controls.Add(this.label4);
            this.tabPageEmployee1.Controls.Add(this.label1);
            this.tabPageEmployee1.Controls.Add(this.txtPrsFullName1);
            this.tabPageEmployee1.Location = new System.Drawing.Point(4, 4);
            this.tabPageEmployee1.Name = "tabPageEmployee1";
            this.tabPageEmployee1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee1.Size = new System.Drawing.Size(1028, 129);
            this.tabPageEmployee1.TabIndex = 0;
            this.tabPageEmployee1.Text = "Основная информация";
            this.tabPageEmployee1.UseVisualStyleBackColor = true;
            // 
            // txtPrsDateDismissed
            // 
            this.txtPrsDateDismissed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrsDateDismissed.Location = new System.Drawing.Point(251, 64);
            this.txtPrsDateDismissed.Name = "txtPrsDateDismissed";
            this.txtPrsDateDismissed.ReadOnly = true;
            this.txtPrsDateDismissed.Size = new System.Drawing.Size(120, 22);
            this.txtPrsDateDismissed.TabIndex = 42;
            // 
            // txtPrsDateHired
            // 
            this.txtPrsDateHired.Location = new System.Drawing.Point(121, 64);
            this.txtPrsDateHired.Name = "txtPrsDateHired";
            this.txtPrsDateHired.ReadOnly = true;
            this.txtPrsDateHired.Size = new System.Drawing.Size(120, 22);
            this.txtPrsDateHired.TabIndex = 41;
            // 
            // txtPrsDateBirth
            // 
            this.txtPrsDateBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrsDateBirth.Location = new System.Drawing.Point(513, 62);
            this.txtPrsDateBirth.Name = "txtPrsDateBirth";
            this.txtPrsDateBirth.ReadOnly = true;
            this.txtPrsDateBirth.Size = new System.Drawing.Size(124, 22);
            this.txtPrsDateBirth.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(668, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Другая связь";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(668, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Почта";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(668, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Телефон";
            // 
            // txtPrsContactOther
            // 
            this.txtPrsContactOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrsContactOther.Location = new System.Drawing.Point(779, 59);
            this.txtPrsContactOther.Multiline = true;
            this.txtPrsContactOther.Name = "txtPrsContactOther";
            this.txtPrsContactOther.ReadOnly = true;
            this.txtPrsContactOther.Size = new System.Drawing.Size(186, 48);
            this.txtPrsContactOther.TabIndex = 9;
            // 
            // txtPrsContactEmail
            // 
            this.txtPrsContactEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrsContactEmail.Location = new System.Drawing.Point(779, 32);
            this.txtPrsContactEmail.Name = "txtPrsContactEmail";
            this.txtPrsContactEmail.ReadOnly = true;
            this.txtPrsContactEmail.Size = new System.Drawing.Size(186, 22);
            this.txtPrsContactEmail.TabIndex = 8;
            // 
            // txtPrsContactPhone
            // 
            this.txtPrsContactPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrsContactPhone.Location = new System.Drawing.Point(779, 6);
            this.txtPrsContactPhone.Name = "txtPrsContactPhone";
            this.txtPrsContactPhone.ReadOnly = true;
            this.txtPrsContactPhone.Size = new System.Drawing.Size(186, 22);
            this.txtPrsContactPhone.TabIndex = 7;
            // 
            // txtPrsHoursWeek
            // 
            this.txtPrsHoursWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrsHoursWeek.Location = new System.Drawing.Point(513, 34);
            this.txtPrsHoursWeek.Name = "txtPrsHoursWeek";
            this.txtPrsHoursWeek.ReadOnly = true;
            this.txtPrsHoursWeek.Size = new System.Drawing.Size(124, 22);
            this.txtPrsHoursWeek.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(405, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Часы/неделя";
            // 
            // txtPrsRoomNum
            // 
            this.txtPrsRoomNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrsRoomNum.Location = new System.Drawing.Point(513, 6);
            this.txtPrsRoomNum.Name = "txtPrsRoomNum";
            this.txtPrsRoomNum.ReadOnly = true;
            this.txtPrsRoomNum.Size = new System.Drawing.Size(124, 22);
            this.txtPrsRoomNum.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(406, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Помещение";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Должность";
            // 
            // txtPrsPosition
            // 
            this.txtPrsPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrsPosition.Location = new System.Drawing.Point(121, 34);
            this.txtPrsPosition.Name = "txtPrsPosition";
            this.txtPrsPosition.ReadOnly = true;
            this.txtPrsPosition.Size = new System.Drawing.Size(250, 22);
            this.txtPrsPosition.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Принят / уволен";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата рождения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО";
            // 
            // txtPrsFullName1
            // 
            this.txtPrsFullName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrsFullName1.Location = new System.Drawing.Point(121, 6);
            this.txtPrsFullName1.Name = "txtPrsFullName1";
            this.txtPrsFullName1.ReadOnly = true;
            this.txtPrsFullName1.Size = new System.Drawing.Size(250, 22);
            this.txtPrsFullName1.TabIndex = 0;
            // 
            // tabPageEmployee2
            // 
            this.tabPageEmployee2.Controls.Add(this.label3);
            this.tabPageEmployee2.Controls.Add(this.txtPrsFullName2);
            this.tabPageEmployee2.Location = new System.Drawing.Point(4, 4);
            this.tabPageEmployee2.Name = "tabPageEmployee2";
            this.tabPageEmployee2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee2.Size = new System.Drawing.Size(1028, 129);
            this.tabPageEmployee2.TabIndex = 1;
            this.tabPageEmployee2.Text = "Сертификаты";
            this.tabPageEmployee2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "ФИО";
            // 
            // txtPrsFullName2
            // 
            this.txtPrsFullName2.Location = new System.Drawing.Point(121, 6);
            this.txtPrsFullName2.Name = "txtPrsFullName2";
            this.txtPrsFullName2.ReadOnly = true;
            this.txtPrsFullName2.Size = new System.Drawing.Size(250, 22);
            this.txtPrsFullName2.TabIndex = 10;
            // 
            // tabPageEmployee3
            // 
            this.tabPageEmployee3.Controls.Add(this.label2);
            this.tabPageEmployee3.Controls.Add(this.txtPrsFullName3);
            this.tabPageEmployee3.Location = new System.Drawing.Point(4, 4);
            this.tabPageEmployee3.Name = "tabPageEmployee3";
            this.tabPageEmployee3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee3.Size = new System.Drawing.Size(1028, 129);
            this.tabPageEmployee3.TabIndex = 2;
            this.tabPageEmployee3.Text = "Хранение";
            this.tabPageEmployee3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ФИО";
            // 
            // txtPrsFullName3
            // 
            this.txtPrsFullName3.Location = new System.Drawing.Point(121, 6);
            this.txtPrsFullName3.Name = "txtPrsFullName3";
            this.txtPrsFullName3.ReadOnly = true;
            this.txtPrsFullName3.Size = new System.Drawing.Size(250, 22);
            this.txtPrsFullName3.TabIndex = 12;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnPrsnAdd,
            this.tsBtnPrsnEdit,
            this.toolStripSeparator12,
            this.tsBtnPrsnDismiss,
            this.toolStripSeparator10,
            this.tsBtnPrsnDelete,
            this.toolStripSeparator13,
            this.tsBtnPrsnRefresh,
            this.tsBtnPrsnToggleConcurrent,
            this.toolStripSeparator14});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1036, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "tsPersonnelTable";
            // 
            // tsBtnPrsnAdd
            // 
            this.tsBtnPrsnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrsnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrsnAdd.Image")));
            this.tsBtnPrsnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrsnAdd.Name = "tsBtnPrsnAdd";
            this.tsBtnPrsnAdd.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrsnAdd.Text = "Добавить";
            this.tsBtnPrsnAdd.Click += new System.EventHandler(this.tsBtnPrsnAdd_Click);
            // 
            // tsBtnPrsnEdit
            // 
            this.tsBtnPrsnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrsnEdit.Image = global::PersonnelMgt.Properties.Resources.Edit_16x;
            this.tsBtnPrsnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrsnEdit.Name = "tsBtnPrsnEdit";
            this.tsBtnPrsnEdit.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrsnEdit.Text = "Редактировать";
            this.tsBtnPrsnEdit.Click += new System.EventHandler(this.tsBtnPrsnEdit_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnPrsnDismiss
            // 
            this.tsBtnPrsnDismiss.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrsnDismiss.Image = global::PersonnelMgt.Properties.Resources.Cancel_16x;
            this.tsBtnPrsnDismiss.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrsnDismiss.Name = "tsBtnPrsnDismiss";
            this.tsBtnPrsnDismiss.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrsnDismiss.Text = "Уволить";
            this.tsBtnPrsnDismiss.Click += new System.EventHandler(this.tsBtnPrsnDismiss_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnPrsnDelete
            // 
            this.tsBtnPrsnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrsnDelete.Image = global::PersonnelMgt.Properties.Resources.HotSpot_16x;
            this.tsBtnPrsnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrsnDelete.Name = "tsBtnPrsnDelete";
            this.tsBtnPrsnDelete.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrsnDelete.Text = "Стереть данные сотрудника";
            this.tsBtnPrsnDelete.Click += new System.EventHandler(this.tsBtnPrsnDelete_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnPrsnRefresh
            // 
            this.tsBtnPrsnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrsnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrsnRefresh.Image")));
            this.tsBtnPrsnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrsnRefresh.Name = "tsBtnPrsnRefresh";
            this.tsBtnPrsnRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrsnRefresh.Text = "Обновить";
            this.tsBtnPrsnRefresh.Click += new System.EventHandler(this.tsBtnPrsnRefresh_Click);
            // 
            // tsBtnPrsnToggleConcurrent
            // 
            this.tsBtnPrsnToggleConcurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrsnToggleConcurrent.Image = global::PersonnelMgt.Properties.Resources.History_16x;
            this.tsBtnPrsnToggleConcurrent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrsnToggleConcurrent.Name = "tsBtnPrsnToggleConcurrent";
            this.tsBtnPrsnToggleConcurrent.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrsnToggleConcurrent.Text = "Показать ранее работавших";
            this.tsBtnPrsnToggleConcurrent.Click += new System.EventHandler(this.tsBtnPrsnToggleConcurrent_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPageReports
            // 
            this.tabPageReports.Controls.Add(this.tabControlReports);
            this.tabPageReports.Controls.Add(this.chkReportSplitDepts);
            this.tabPageReports.Controls.Add(this.cmbReportOrg);
            this.tabPageReports.Controls.Add(this.label6);
            this.tabPageReports.Controls.Add(this.cmbReportType);
            this.tabPageReports.Controls.Add(this.label5);
            this.tabPageReports.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(1042, 549);
            this.tabPageReports.TabIndex = 1;
            this.tabPageReports.Text = "Отчёты";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // tabControlReports
            // 
            this.tabControlReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlReports.Controls.Add(this.tabPageReports1);
            this.tabControlReports.Controls.Add(this.tabPageReports2);
            this.tabControlReports.Controls.Add(this.tabPageReports3);
            this.tabControlReports.Location = new System.Drawing.Point(6, 55);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(1028, 486);
            this.tabControlReports.TabIndex = 0;
            this.tabControlReports.Visible = false;
            // 
            // tabPageReports1
            // 
            this.tabPageReports1.Controls.Add(this.dgvReport1);
            this.tabPageReports1.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports1.Name = "tabPageReports1";
            this.tabPageReports1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports1.Size = new System.Drawing.Size(1020, 457);
            this.tabPageReports1.TabIndex = 0;
            this.tabPageReports1.Text = "Сотрудники";
            this.tabPageReports1.UseVisualStyleBackColor = true;
            // 
            // dgvReport1
            // 
            this.dgvReport1.AllowUserToAddRows = false;
            this.dgvReport1.AllowUserToDeleteRows = false;
            this.dgvReport1.AllowUserToResizeRows = false;
            this.dgvReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcReport1_IdEmployee,
            this.dgvcReport1_RowNum,
            this.dgvcReport1_NameFull,
            this.dgvcReport1_Position,
            this.dgvcReport1_DateHired});
            this.dgvReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport1.Location = new System.Drawing.Point(3, 3);
            this.dgvReport1.Name = "dgvReport1";
            this.dgvReport1.ReadOnly = true;
            this.dgvReport1.RowHeadersVisible = false;
            this.dgvReport1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReport1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport1.Size = new System.Drawing.Size(1014, 451);
            this.dgvReport1.TabIndex = 2;
            // 
            // dgvcReport1_IdEmployee
            // 
            this.dgvcReport1_IdEmployee.DataPropertyName = "id_employee";
            this.dgvcReport1_IdEmployee.HeaderText = "ID_EMPLOYEE";
            this.dgvcReport1_IdEmployee.Name = "dgvcReport1_IdEmployee";
            this.dgvcReport1_IdEmployee.ReadOnly = true;
            this.dgvcReport1_IdEmployee.Visible = false;
            // 
            // dgvcReport1_RowNum
            // 
            this.dgvcReport1_RowNum.DataPropertyName = "row_n";
            this.dgvcReport1_RowNum.HeaderText = "№";
            this.dgvcReport1_RowNum.Name = "dgvcReport1_RowNum";
            this.dgvcReport1_RowNum.ReadOnly = true;
            this.dgvcReport1_RowNum.Width = 60;
            // 
            // dgvcReport1_NameFull
            // 
            this.dgvcReport1_NameFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcReport1_NameFull.DataPropertyName = "name_full";
            this.dgvcReport1_NameFull.HeaderText = "Имя";
            this.dgvcReport1_NameFull.MinimumWidth = 210;
            this.dgvcReport1_NameFull.Name = "dgvcReport1_NameFull";
            this.dgvcReport1_NameFull.ReadOnly = true;
            this.dgvcReport1_NameFull.Width = 210;
            // 
            // dgvcReport1_Position
            // 
            this.dgvcReport1_Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcReport1_Position.DataPropertyName = "position";
            this.dgvcReport1_Position.HeaderText = "Должность";
            this.dgvcReport1_Position.MinimumWidth = 130;
            this.dgvcReport1_Position.Name = "dgvcReport1_Position";
            this.dgvcReport1_Position.ReadOnly = true;
            this.dgvcReport1_Position.Width = 130;
            // 
            // dgvcReport1_DateHired
            // 
            this.dgvcReport1_DateHired.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcReport1_DateHired.DataPropertyName = "date_hired";
            this.dgvcReport1_DateHired.HeaderText = "Принят";
            this.dgvcReport1_DateHired.MinimumWidth = 115;
            this.dgvcReport1_DateHired.Name = "dgvcReport1_DateHired";
            this.dgvcReport1_DateHired.ReadOnly = true;
            // 
            // tabPageReports2
            // 
            this.tabPageReports2.Controls.Add(this.dgvReport2);
            this.tabPageReports2.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports2.Name = "tabPageReports2";
            this.tabPageReports2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports2.Size = new System.Drawing.Size(1020, 457);
            this.tabPageReports2.TabIndex = 1;
            this.tabPageReports2.Text = "Департаменты";
            this.tabPageReports2.UseVisualStyleBackColor = true;
            // 
            // dgvReport2
            // 
            this.dgvReport2.AllowUserToAddRows = false;
            this.dgvReport2.AllowUserToDeleteRows = false;
            this.dgvReport2.AllowUserToResizeRows = false;
            this.dgvReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcReport2_IdEmployee,
            this.dgvcReport2_IdDept,
            this.dgvcReport2_RowNumber,
            this.dgvcReport2_DeptName,
            this.dgvcReport2_NameFull,
            this.dgcvReport2_Position,
            this.dgvcReport2_DateHired});
            this.dgvReport2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport2.Location = new System.Drawing.Point(3, 3);
            this.dgvReport2.Name = "dgvReport2";
            this.dgvReport2.ReadOnly = true;
            this.dgvReport2.RowHeadersVisible = false;
            this.dgvReport2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReport2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport2.Size = new System.Drawing.Size(1014, 451);
            this.dgvReport2.TabIndex = 1;
            // 
            // dgvcReport2_IdEmployee
            // 
            this.dgvcReport2_IdEmployee.DataPropertyName = "id_employee";
            this.dgvcReport2_IdEmployee.HeaderText = "ID_EMPLOYEE";
            this.dgvcReport2_IdEmployee.Name = "dgvcReport2_IdEmployee";
            this.dgvcReport2_IdEmployee.ReadOnly = true;
            this.dgvcReport2_IdEmployee.Visible = false;
            // 
            // dgvcReport2_IdDept
            // 
            this.dgvcReport2_IdDept.DataPropertyName = "id_dept";
            this.dgvcReport2_IdDept.HeaderText = "ID_DEPT";
            this.dgvcReport2_IdDept.Name = "dgvcReport2_IdDept";
            this.dgvcReport2_IdDept.ReadOnly = true;
            this.dgvcReport2_IdDept.Visible = false;
            // 
            // dgvcReport2_RowNumber
            // 
            this.dgvcReport2_RowNumber.DataPropertyName = "row_n";
            this.dgvcReport2_RowNumber.HeaderText = "№";
            this.dgvcReport2_RowNumber.Name = "dgvcReport2_RowNumber";
            this.dgvcReport2_RowNumber.ReadOnly = true;
            this.dgvcReport2_RowNumber.Width = 60;
            // 
            // dgvcReport2_DeptName
            // 
            this.dgvcReport2_DeptName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcReport2_DeptName.DataPropertyName = "dept_name";
            this.dgvcReport2_DeptName.HeaderText = "Департамент";
            this.dgvcReport2_DeptName.Name = "dgvcReport2_DeptName";
            this.dgvcReport2_DeptName.ReadOnly = true;
            this.dgvcReport2_DeptName.Visible = false;
            // 
            // dgvcReport2_NameFull
            // 
            this.dgvcReport2_NameFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcReport2_NameFull.DataPropertyName = "name_full";
            this.dgvcReport2_NameFull.HeaderText = "Имя";
            this.dgvcReport2_NameFull.MinimumWidth = 210;
            this.dgvcReport2_NameFull.Name = "dgvcReport2_NameFull";
            this.dgvcReport2_NameFull.ReadOnly = true;
            this.dgvcReport2_NameFull.Width = 210;
            // 
            // dgcvReport2_Position
            // 
            this.dgcvReport2_Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcvReport2_Position.DataPropertyName = "position";
            this.dgcvReport2_Position.HeaderText = "Должность";
            this.dgcvReport2_Position.MinimumWidth = 130;
            this.dgcvReport2_Position.Name = "dgcvReport2_Position";
            this.dgcvReport2_Position.ReadOnly = true;
            this.dgcvReport2_Position.Width = 130;
            // 
            // dgvcReport2_DateHired
            // 
            this.dgvcReport2_DateHired.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcReport2_DateHired.DataPropertyName = "date_hired";
            this.dgvcReport2_DateHired.HeaderText = "Принят";
            this.dgvcReport2_DateHired.MinimumWidth = 115;
            this.dgvcReport2_DateHired.Name = "dgvcReport2_DateHired";
            this.dgvcReport2_DateHired.ReadOnly = true;
            // 
            // tabPageReports3
            // 
            this.tabPageReports3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageReports3.Controls.Add(this.txtReport3_q1_F2);
            this.tabPageReports3.Controls.Add(this.label43);
            this.tabPageReports3.Controls.Add(this.txtReport3_q1_F1);
            this.tabPageReports3.Controls.Add(this.label44);
            this.tabPageReports3.Controls.Add(this.txtReport3_q4_F2);
            this.tabPageReports3.Controls.Add(this.label38);
            this.tabPageReports3.Controls.Add(this.txtReport3_q4_F1);
            this.tabPageReports3.Controls.Add(this.label39);
            this.tabPageReports3.Controls.Add(this.txtReport3_q3_F2);
            this.tabPageReports3.Controls.Add(this.label27);
            this.tabPageReports3.Controls.Add(this.txtReport3_q3_F1);
            this.tabPageReports3.Controls.Add(this.label28);
            this.tabPageReports3.Controls.Add(this.txtReport3_q2_F2);
            this.tabPageReports3.Controls.Add(this.label16);
            this.tabPageReports3.Controls.Add(this.txtReport3_q2_F1);
            this.tabPageReports3.Controls.Add(this.label17);
            this.tabPageReports3.Controls.Add(this.lblReport3_q4_4_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q4_3_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q4_2_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q4_1_Value);
            this.tabPageReports3.Controls.Add(this.label33);
            this.tabPageReports3.Controls.Add(this.label34);
            this.tabPageReports3.Controls.Add(this.label35);
            this.tabPageReports3.Controls.Add(this.label36);
            this.tabPageReports3.Controls.Add(this.label37);
            this.tabPageReports3.Controls.Add(this.lblReport3_q3_4_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q3_3_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q3_2_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q3_1_Value);
            this.tabPageReports3.Controls.Add(this.label46);
            this.tabPageReports3.Controls.Add(this.label47);
            this.tabPageReports3.Controls.Add(this.label48);
            this.tabPageReports3.Controls.Add(this.label49);
            this.tabPageReports3.Controls.Add(this.label50);
            this.tabPageReports3.Controls.Add(this.lblReport3_q2_4_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q2_3_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q2_2_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q2_1_Value);
            this.tabPageReports3.Controls.Add(this.label22);
            this.tabPageReports3.Controls.Add(this.label23);
            this.tabPageReports3.Controls.Add(this.label24);
            this.tabPageReports3.Controls.Add(this.label25);
            this.tabPageReports3.Controls.Add(this.label26);
            this.tabPageReports3.Controls.Add(this.lblReport3_q1_4_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q1_3_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q1_2_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q1_1_Value);
            this.tabPageReports3.Controls.Add(this.lblReport3_q1_4);
            this.tabPageReports3.Controls.Add(this.lblReport3_q1_3);
            this.tabPageReports3.Controls.Add(this.lblReport3_q1_2);
            this.tabPageReports3.Controls.Add(this.lblReport3_q1_1);
            this.tabPageReports3.Controls.Add(this.label15);
            this.tabPageReports3.Controls.Add(this.btnReport3_Apply);
            this.tabPageReports3.Controls.Add(this.mtxtReport3_Year);
            this.tabPageReports3.Controls.Add(this.label7);
            this.tabPageReports3.Location = new System.Drawing.Point(4, 25);
            this.tabPageReports3.Name = "tabPageReports3";
            this.tabPageReports3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports3.Size = new System.Drawing.Size(1020, 457);
            this.tabPageReports3.TabIndex = 2;
            this.tabPageReports3.Text = "Прибыль/убыль";
            this.tabPageReports3.UseVisualStyleBackColor = true;
            // 
            // txtReport3_q1_F2
            // 
            this.txtReport3_q1_F2.Location = new System.Drawing.Point(174, 82);
            this.txtReport3_q1_F2.Name = "txtReport3_q1_F2";
            this.txtReport3_q1_F2.ReadOnly = true;
            this.txtReport3_q1_F2.Size = new System.Drawing.Size(197, 22);
            this.txtReport3_q1_F2.TabIndex = 3;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(40, 82);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(58, 16);
            this.label43.TabIndex = 94;
            this.label43.Text = "Текучка:";
            // 
            // txtReport3_q1_F1
            // 
            this.txtReport3_q1_F1.Location = new System.Drawing.Point(174, 55);
            this.txtReport3_q1_F1.Name = "txtReport3_q1_F1";
            this.txtReport3_q1_F1.ReadOnly = true;
            this.txtReport3_q1_F1.Size = new System.Drawing.Size(197, 22);
            this.txtReport3_q1_F1.TabIndex = 2;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(40, 55);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(106, 16);
            this.label44.TabIndex = 3;
            this.label44.Text = "Прибыль/убыль:";
            // 
            // txtReport3_q4_F2
            // 
            this.txtReport3_q4_F2.Location = new System.Drawing.Point(174, 402);
            this.txtReport3_q4_F2.Name = "txtReport3_q4_F2";
            this.txtReport3_q4_F2.ReadOnly = true;
            this.txtReport3_q4_F2.Size = new System.Drawing.Size(197, 22);
            this.txtReport3_q4_F2.TabIndex = 9;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(40, 402);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(58, 16);
            this.label38.TabIndex = 90;
            this.label38.Text = "Текучка:";
            // 
            // txtReport3_q4_F1
            // 
            this.txtReport3_q4_F1.Location = new System.Drawing.Point(174, 375);
            this.txtReport3_q4_F1.Name = "txtReport3_q4_F1";
            this.txtReport3_q4_F1.ReadOnly = true;
            this.txtReport3_q4_F1.Size = new System.Drawing.Size(197, 22);
            this.txtReport3_q4_F1.TabIndex = 8;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(40, 375);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(106, 16);
            this.label39.TabIndex = 88;
            this.label39.Text = "Прибыль/убыль:";
            // 
            // txtReport3_q3_F2
            // 
            this.txtReport3_q3_F2.Location = new System.Drawing.Point(174, 293);
            this.txtReport3_q3_F2.Name = "txtReport3_q3_F2";
            this.txtReport3_q3_F2.ReadOnly = true;
            this.txtReport3_q3_F2.Size = new System.Drawing.Size(197, 22);
            this.txtReport3_q3_F2.TabIndex = 7;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(40, 293);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 16);
            this.label27.TabIndex = 86;
            this.label27.Text = "Текучка:";
            // 
            // txtReport3_q3_F1
            // 
            this.txtReport3_q3_F1.Location = new System.Drawing.Point(174, 266);
            this.txtReport3_q3_F1.Name = "txtReport3_q3_F1";
            this.txtReport3_q3_F1.ReadOnly = true;
            this.txtReport3_q3_F1.Size = new System.Drawing.Size(197, 22);
            this.txtReport3_q3_F1.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(40, 266);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(106, 16);
            this.label28.TabIndex = 84;
            this.label28.Text = "Прибыль/убыль:";
            // 
            // txtReport3_q2_F2
            // 
            this.txtReport3_q2_F2.Location = new System.Drawing.Point(174, 185);
            this.txtReport3_q2_F2.Name = "txtReport3_q2_F2";
            this.txtReport3_q2_F2.ReadOnly = true;
            this.txtReport3_q2_F2.Size = new System.Drawing.Size(197, 22);
            this.txtReport3_q2_F2.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 82;
            this.label16.Text = "Текучка:";
            // 
            // txtReport3_q2_F1
            // 
            this.txtReport3_q2_F1.Location = new System.Drawing.Point(174, 158);
            this.txtReport3_q2_F1.Name = "txtReport3_q2_F1";
            this.txtReport3_q2_F1.ReadOnly = true;
            this.txtReport3_q2_F1.Size = new System.Drawing.Size(197, 22);
            this.txtReport3_q2_F1.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 16);
            this.label17.TabIndex = 80;
            this.label17.Text = "Прибыль/убыль:";
            // 
            // lblReport3_q4_4_Value
            // 
            this.lblReport3_q4_4_Value.AutoSize = true;
            this.lblReport3_q4_4_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q4_4_Value.Location = new System.Drawing.Point(643, 420);
            this.lblReport3_q4_4_Value.Name = "lblReport3_q4_4_Value";
            this.lblReport3_q4_4_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q4_4_Value.TabIndex = 79;
            this.lblReport3_q4_4_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q4_3_Value
            // 
            this.lblReport3_q4_3_Value.AutoSize = true;
            this.lblReport3_q4_3_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q4_3_Value.Location = new System.Drawing.Point(643, 402);
            this.lblReport3_q4_3_Value.Name = "lblReport3_q4_3_Value";
            this.lblReport3_q4_3_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q4_3_Value.TabIndex = 78;
            this.lblReport3_q4_3_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q4_2_Value
            // 
            this.lblReport3_q4_2_Value.AutoSize = true;
            this.lblReport3_q4_2_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q4_2_Value.Location = new System.Drawing.Point(643, 384);
            this.lblReport3_q4_2_Value.Name = "lblReport3_q4_2_Value";
            this.lblReport3_q4_2_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q4_2_Value.TabIndex = 77;
            this.lblReport3_q4_2_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q4_1_Value
            // 
            this.lblReport3_q4_1_Value.AutoSize = true;
            this.lblReport3_q4_1_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q4_1_Value.Location = new System.Drawing.Point(643, 366);
            this.lblReport3_q4_1_Value.Name = "lblReport3_q4_1_Value";
            this.lblReport3_q4_1_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q4_1_Value.TabIndex = 76;
            this.lblReport3_q4_1_Value.Text = "% ЗНАЧ %";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(467, 420);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(162, 16);
            this.label33.TabIndex = 75;
            this.label33.Text = "Кол-во на конец периода:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(467, 402);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(139, 16);
            this.label34.TabIndex = 74;
            this.label34.Text = "Уволилось за период:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(467, 384);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(125, 16);
            this.label35.TabIndex = 73;
            this.label35.Text = "Принято за период:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(467, 366);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(170, 16);
            this.label36.TabIndex = 72;
            this.label36.Text = "Кол-во на начало периода:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(18, 341);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(144, 16);
            this.label37.TabIndex = 71;
            this.label37.Text = "[4] Квартал: четвёртый";
            // 
            // lblReport3_q3_4_Value
            // 
            this.lblReport3_q3_4_Value.AutoSize = true;
            this.lblReport3_q3_4_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q3_4_Value.Location = new System.Drawing.Point(643, 311);
            this.lblReport3_q3_4_Value.Name = "lblReport3_q3_4_Value";
            this.lblReport3_q3_4_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q3_4_Value.TabIndex = 66;
            this.lblReport3_q3_4_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q3_3_Value
            // 
            this.lblReport3_q3_3_Value.AutoSize = true;
            this.lblReport3_q3_3_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q3_3_Value.Location = new System.Drawing.Point(643, 293);
            this.lblReport3_q3_3_Value.Name = "lblReport3_q3_3_Value";
            this.lblReport3_q3_3_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q3_3_Value.TabIndex = 65;
            this.lblReport3_q3_3_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q3_2_Value
            // 
            this.lblReport3_q3_2_Value.AutoSize = true;
            this.lblReport3_q3_2_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q3_2_Value.Location = new System.Drawing.Point(643, 275);
            this.lblReport3_q3_2_Value.Name = "lblReport3_q3_2_Value";
            this.lblReport3_q3_2_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q3_2_Value.TabIndex = 64;
            this.lblReport3_q3_2_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q3_1_Value
            // 
            this.lblReport3_q3_1_Value.AutoSize = true;
            this.lblReport3_q3_1_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q3_1_Value.Location = new System.Drawing.Point(643, 257);
            this.lblReport3_q3_1_Value.Name = "lblReport3_q3_1_Value";
            this.lblReport3_q3_1_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q3_1_Value.TabIndex = 63;
            this.lblReport3_q3_1_Value.Text = "% ЗНАЧ %";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(467, 311);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(162, 16);
            this.label46.TabIndex = 62;
            this.label46.Text = "Кол-во на конец периода:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(467, 293);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(139, 16);
            this.label47.TabIndex = 61;
            this.label47.Text = "Уволилось за период:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(467, 275);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(125, 16);
            this.label48.TabIndex = 60;
            this.label48.Text = "Принято за период:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(467, 257);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(170, 16);
            this.label49.TabIndex = 59;
            this.label49.Text = "Кол-во на начало периода:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(18, 232);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(121, 16);
            this.label50.TabIndex = 58;
            this.label50.Text = "[3] Квартал: третий";
            // 
            // lblReport3_q2_4_Value
            // 
            this.lblReport3_q2_4_Value.AutoSize = true;
            this.lblReport3_q2_4_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q2_4_Value.Location = new System.Drawing.Point(643, 203);
            this.lblReport3_q2_4_Value.Name = "lblReport3_q2_4_Value";
            this.lblReport3_q2_4_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q2_4_Value.TabIndex = 53;
            this.lblReport3_q2_4_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q2_3_Value
            // 
            this.lblReport3_q2_3_Value.AutoSize = true;
            this.lblReport3_q2_3_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q2_3_Value.Location = new System.Drawing.Point(643, 185);
            this.lblReport3_q2_3_Value.Name = "lblReport3_q2_3_Value";
            this.lblReport3_q2_3_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q2_3_Value.TabIndex = 52;
            this.lblReport3_q2_3_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q2_2_Value
            // 
            this.lblReport3_q2_2_Value.AutoSize = true;
            this.lblReport3_q2_2_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q2_2_Value.Location = new System.Drawing.Point(643, 167);
            this.lblReport3_q2_2_Value.Name = "lblReport3_q2_2_Value";
            this.lblReport3_q2_2_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q2_2_Value.TabIndex = 51;
            this.lblReport3_q2_2_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q2_1_Value
            // 
            this.lblReport3_q2_1_Value.AutoSize = true;
            this.lblReport3_q2_1_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q2_1_Value.Location = new System.Drawing.Point(643, 149);
            this.lblReport3_q2_1_Value.Name = "lblReport3_q2_1_Value";
            this.lblReport3_q2_1_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q2_1_Value.TabIndex = 50;
            this.lblReport3_q2_1_Value.Text = "% ЗНАЧ %";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(467, 203);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(162, 16);
            this.label22.TabIndex = 49;
            this.label22.Text = "Кол-во на конец периода:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(467, 185);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(139, 16);
            this.label23.TabIndex = 48;
            this.label23.Text = "Уволилось за период:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(467, 167);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(125, 16);
            this.label24.TabIndex = 47;
            this.label24.Text = "Принято за период:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(467, 149);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(170, 16);
            this.label25.TabIndex = 46;
            this.label25.Text = "Кол-во на начало периода:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 124);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 16);
            this.label26.TabIndex = 45;
            this.label26.Text = "[2] Квартал: второй";
            // 
            // lblReport3_q1_4_Value
            // 
            this.lblReport3_q1_4_Value.AutoSize = true;
            this.lblReport3_q1_4_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q1_4_Value.Location = new System.Drawing.Point(643, 94);
            this.lblReport3_q1_4_Value.Name = "lblReport3_q1_4_Value";
            this.lblReport3_q1_4_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q1_4_Value.TabIndex = 13;
            this.lblReport3_q1_4_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q1_3_Value
            // 
            this.lblReport3_q1_3_Value.AutoSize = true;
            this.lblReport3_q1_3_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q1_3_Value.Location = new System.Drawing.Point(643, 76);
            this.lblReport3_q1_3_Value.Name = "lblReport3_q1_3_Value";
            this.lblReport3_q1_3_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q1_3_Value.TabIndex = 12;
            this.lblReport3_q1_3_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q1_2_Value
            // 
            this.lblReport3_q1_2_Value.AutoSize = true;
            this.lblReport3_q1_2_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q1_2_Value.Location = new System.Drawing.Point(643, 58);
            this.lblReport3_q1_2_Value.Name = "lblReport3_q1_2_Value";
            this.lblReport3_q1_2_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q1_2_Value.TabIndex = 11;
            this.lblReport3_q1_2_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q1_1_Value
            // 
            this.lblReport3_q1_1_Value.AutoSize = true;
            this.lblReport3_q1_1_Value.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReport3_q1_1_Value.Location = new System.Drawing.Point(643, 40);
            this.lblReport3_q1_1_Value.Name = "lblReport3_q1_1_Value";
            this.lblReport3_q1_1_Value.Size = new System.Drawing.Size(78, 17);
            this.lblReport3_q1_1_Value.TabIndex = 10;
            this.lblReport3_q1_1_Value.Text = "% ЗНАЧ %";
            // 
            // lblReport3_q1_4
            // 
            this.lblReport3_q1_4.AutoSize = true;
            this.lblReport3_q1_4.Location = new System.Drawing.Point(467, 94);
            this.lblReport3_q1_4.Name = "lblReport3_q1_4";
            this.lblReport3_q1_4.Size = new System.Drawing.Size(162, 16);
            this.lblReport3_q1_4.TabIndex = 9;
            this.lblReport3_q1_4.Text = "Кол-во на конец периода:";
            // 
            // lblReport3_q1_3
            // 
            this.lblReport3_q1_3.AutoSize = true;
            this.lblReport3_q1_3.Location = new System.Drawing.Point(467, 76);
            this.lblReport3_q1_3.Name = "lblReport3_q1_3";
            this.lblReport3_q1_3.Size = new System.Drawing.Size(139, 16);
            this.lblReport3_q1_3.TabIndex = 8;
            this.lblReport3_q1_3.Text = "Уволилось за период:";
            // 
            // lblReport3_q1_2
            // 
            this.lblReport3_q1_2.AutoSize = true;
            this.lblReport3_q1_2.Location = new System.Drawing.Point(467, 58);
            this.lblReport3_q1_2.Name = "lblReport3_q1_2";
            this.lblReport3_q1_2.Size = new System.Drawing.Size(125, 16);
            this.lblReport3_q1_2.TabIndex = 7;
            this.lblReport3_q1_2.Text = "Принято за период:";
            // 
            // lblReport3_q1_1
            // 
            this.lblReport3_q1_1.AutoSize = true;
            this.lblReport3_q1_1.Location = new System.Drawing.Point(467, 40);
            this.lblReport3_q1_1.Name = "lblReport3_q1_1";
            this.lblReport3_q1_1.Size = new System.Drawing.Size(170, 16);
            this.lblReport3_q1_1.TabIndex = 6;
            this.lblReport3_q1_1.Text = "Кол-во на начало периода:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "[1] Квартал: первый";
            // 
            // btnReport3_Apply
            // 
            this.btnReport3_Apply.Location = new System.Drawing.Point(854, 9);
            this.btnReport3_Apply.Name = "btnReport3_Apply";
            this.btnReport3_Apply.Size = new System.Drawing.Size(88, 23);
            this.btnReport3_Apply.TabIndex = 1;
            this.btnReport3_Apply.Text = "Применить";
            this.btnReport3_Apply.UseVisualStyleBackColor = true;
            this.btnReport3_Apply.Click += new System.EventHandler(this.btnReport3_Apply_Click);
            // 
            // mtxtReport3_Year
            // 
            this.mtxtReport3_Year.Location = new System.Drawing.Point(772, 9);
            this.mtxtReport3_Year.Mask = "0000";
            this.mtxtReport3_Year.Name = "mtxtReport3_Year";
            this.mtxtReport3_Year.Size = new System.Drawing.Size(66, 22);
            this.mtxtReport3_Year.TabIndex = 0;
            this.mtxtReport3_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtReport3_Year.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtReport3_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtReport3_Year_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(733, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Год:";
            // 
            // chkReportSplitDepts
            // 
            this.chkReportSplitDepts.AutoSize = true;
            this.chkReportSplitDepts.Location = new System.Drawing.Point(313, 17);
            this.chkReportSplitDepts.Name = "chkReportSplitDepts";
            this.chkReportSplitDepts.Size = new System.Drawing.Size(139, 20);
            this.chkReportSplitDepts.TabIndex = 4;
            this.chkReportSplitDepts.Text = "По департаментам";
            this.chkReportSplitDepts.UseVisualStyleBackColor = true;
            this.chkReportSplitDepts.CheckedChanged += new System.EventHandler(this.chkReportSplitDepts_CheckedChanged);
            // 
            // cmbReportOrg
            // 
            this.cmbReportOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReportOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportOrg.FormattingEnabled = true;
            this.cmbReportOrg.Items.AddRange(new object[] {
            "Список сотрудников",
            "Прибыль/убыль, утечка"});
            this.cmbReportOrg.Location = new System.Drawing.Point(782, 17);
            this.cmbReportOrg.Name = "cmbReportOrg";
            this.cmbReportOrg.Size = new System.Drawing.Size(212, 24);
            this.cmbReportOrg.TabIndex = 3;
            this.cmbReportOrg.SelectedIndexChanged += new System.EventHandler(this.cmbReportOrg_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Организация:";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Список сотрудников",
            "Прибыль/убыль, текучка"});
            this.cmbReportType.Location = new System.Drawing.Point(68, 14);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(223, 24);
            this.cmbReportType.TabIndex = 1;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Отчёт:";
            // 
            // tabPageDepts
            // 
            this.tabPageDepts.Location = new System.Drawing.Point(4, 25);
            this.tabPageDepts.Name = "tabPageDepts";
            this.tabPageDepts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepts.Size = new System.Drawing.Size(1042, 549);
            this.tabPageDepts.TabIndex = 2;
            this.tabPageDepts.Text = "Отделы";
            this.tabPageDepts.UseVisualStyleBackColor = true;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Location = new System.Drawing.Point(4, 25);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(1042, 549);
            this.tabPageRooms.TabIndex = 3;
            this.tabPageRooms.Text = "Кабинеты";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // tabPageHardware
            // 
            this.tabPageHardware.Location = new System.Drawing.Point(4, 25);
            this.tabPageHardware.Name = "tabPageHardware";
            this.tabPageHardware.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHardware.Size = new System.Drawing.Size(1042, 549);
            this.tabPageHardware.TabIndex = 4;
            this.tabPageHardware.Text = "Техника";
            this.tabPageHardware.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 578);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.tsBtnPersonnel,
            this.toolStripSeparator3,
            this.tsBtnReports,
            this.toolStripSeparator2,
            this.tsBtnDepts,
            this.toolStripSeparator11,
            this.tsBtnRooms,
            this.toolStripSeparator4,
            this.tsBtnHardware,
            this.toolStripSeparator1,
            this.tsBtnApplicants,
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.tsLabelNotifications,
            this.tsDropBtnNotifications,
            this.toolStripSeparator8,
            this.tsBtnInterviews,
            this.toolStripSeparator9});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(80, 578);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(78, 6);
            // 
            // tsBtnPersonnel
            // 
            this.tsBtnPersonnel.Image = global::PersonnelMgt.Properties.Resources.UserProfile_16x;
            this.tsBtnPersonnel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPersonnel.Name = "tsBtnPersonnel";
            this.tsBtnPersonnel.Size = new System.Drawing.Size(78, 35);
            this.tsBtnPersonnel.Text = "Сотрудники";
            this.tsBtnPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnPersonnel.Click += new System.EventHandler(this.tsBtnPersonnel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(78, 6);
            // 
            // tsBtnReports
            // 
            this.tsBtnReports.Image = global::PersonnelMgt.Properties.Resources.ColumnChart_16x;
            this.tsBtnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnReports.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.tsBtnReports.Name = "tsBtnReports";
            this.tsBtnReports.Size = new System.Drawing.Size(78, 35);
            this.tsBtnReports.Text = "Отчёты";
            this.tsBtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnReports.Click += new System.EventHandler(this.tsBtnReports_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(78, 6);
            // 
            // tsBtnDepts
            // 
            this.tsBtnDepts.Enabled = false;
            this.tsBtnDepts.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDepts.Image")));
            this.tsBtnDepts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDepts.Name = "tsBtnDepts";
            this.tsBtnDepts.Size = new System.Drawing.Size(78, 35);
            this.tsBtnDepts.Text = "Отделы";
            this.tsBtnDepts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(78, 6);
            // 
            // tsBtnRooms
            // 
            this.tsBtnRooms.Enabled = false;
            this.tsBtnRooms.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRooms.Image")));
            this.tsBtnRooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRooms.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.tsBtnRooms.Name = "tsBtnRooms";
            this.tsBtnRooms.Size = new System.Drawing.Size(78, 35);
            this.tsBtnRooms.Text = "Кабинеты";
            this.tsBtnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(78, 6);
            // 
            // tsBtnHardware
            // 
            this.tsBtnHardware.Enabled = false;
            this.tsBtnHardware.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnHardware.Image")));
            this.tsBtnHardware.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHardware.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.tsBtnHardware.Name = "tsBtnHardware";
            this.tsBtnHardware.Size = new System.Drawing.Size(78, 35);
            this.tsBtnHardware.Text = "Техника";
            this.tsBtnHardware.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(78, 6);
            // 
            // tsBtnApplicants
            // 
            this.tsBtnApplicants.Enabled = false;
            this.tsBtnApplicants.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnApplicants.Image")));
            this.tsBtnApplicants.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnApplicants.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.tsBtnApplicants.Name = "tsBtnApplicants";
            this.tsBtnApplicants.Size = new System.Drawing.Size(78, 35);
            this.tsBtnApplicants.Text = "Кандидаты";
            this.tsBtnApplicants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(78, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(78, 6);
            // 
            // tsLabelNotifications
            // 
            this.tsLabelNotifications.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLabelNotifications.Name = "tsLabelNotifications";
            this.tsLabelNotifications.Size = new System.Drawing.Size(78, 15);
            this.tsLabelNotifications.Text = "0 увед.";
            // 
            // tsDropBtnNotifications
            // 
            this.tsDropBtnNotifications.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsDropBtnNotifications.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDropBtnNotifications.Image = ((System.Drawing.Image)(resources.GetObject("tsDropBtnNotifications.Image")));
            this.tsDropBtnNotifications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropBtnNotifications.Name = "tsDropBtnNotifications";
            this.tsDropBtnNotifications.Size = new System.Drawing.Size(78, 20);
            this.tsDropBtnNotifications.Text = "Уведомления";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(78, 6);
            // 
            // tsBtnInterviews
            // 
            this.tsBtnInterviews.Enabled = false;
            this.tsBtnInterviews.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnInterviews.Image")));
            this.tsBtnInterviews.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnInterviews.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.tsBtnInterviews.Name = "tsBtnInterviews";
            this.tsBtnInterviews.Size = new System.Drawing.Size(78, 35);
            this.tsBtnInterviews.Text = "Встречи";
            this.tsBtnInterviews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(78, 6);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 602);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Сотрудники компании";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.ResizeBegin += new System.EventHandler(this.FormMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePersonnel.ResumeLayout(false);
            this.tabPagePersonnel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnelTable)).EndInit();
            this.tabControlPersonnel.ResumeLayout(false);
            this.tabPageEmployee1.ResumeLayout(false);
            this.tabPageEmployee1.PerformLayout();
            this.tabPageEmployee2.ResumeLayout(false);
            this.tabPageEmployee2.PerformLayout();
            this.tabPageEmployee3.ResumeLayout(false);
            this.tabPageEmployee3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPageReports.ResumeLayout(false);
            this.tabPageReports.PerformLayout();
            this.tabControlReports.ResumeLayout(false);
            this.tabPageReports1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).EndInit();
            this.tabPageReports2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport2)).EndInit();
            this.tabPageReports3.ResumeLayout(false);
            this.tabPageReports3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabPage tabPagePersonnel;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tsBtnPrsnAdd;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsBtnPersonnel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnReports;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnRooms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnHardware;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnApplicants;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton tsDropBtnNotifications;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel tsLabelNotifications;
        private System.Windows.Forms.DataGridView dgvPersonnelTable;
        private System.Windows.Forms.ToolStripButton tsBtnInterviews;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton tsBtnPrsnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsBtnDepts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.TabControl tabControlPersonnel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageEmployee2;
        private System.Windows.Forms.TabPage tabPageEmployee3;
        private System.Windows.Forms.TabPage tabPageDepts;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.TabPage tabPageHardware;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrsRoomNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrsPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrsHoursWeek;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripButton tsBtnPrsnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tsBtnPrsnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrsFullName2;
        private System.Windows.Forms.ToolStripButton tsBtnPrsnToggleConcurrent;
        private System.Windows.Forms.ToolStripButton tsBtnPrsnDismiss;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.TabPage tabPageEmployee1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPrsContactOther;
        private System.Windows.Forms.TextBox txtPrsContactEmail;
        private System.Windows.Forms.TextBox txtPrsContactPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrsFullName3;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbReportOrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkReportSplitDepts;
        private System.Windows.Forms.TabControl tabControlReports;
        private System.Windows.Forms.TabPage tabPageReports1;
        private System.Windows.Forms.TabPage tabPageReports2;
        private System.Windows.Forms.TabPage tabPageReports3;
        private System.Windows.Forms.DataGridView dgvReport2;
        private System.Windows.Forms.DataGridView dgvReport1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport1_IdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport1_RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport1_NameFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport1_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport1_DateHired;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport2_IdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport2_IdDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport2_RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport2_DeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport2_NameFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcvReport2_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport2_DateHired;
        private System.Windows.Forms.MaskedTextBox mtxtReport3_Year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReport3_Apply;
        private System.Windows.Forms.Label lblReport3_q1_4_Value;
        private System.Windows.Forms.Label lblReport3_q1_3_Value;
        private System.Windows.Forms.Label lblReport3_q1_2_Value;
        private System.Windows.Forms.Label lblReport3_q1_1_Value;
        private System.Windows.Forms.Label lblReport3_q1_4;
        private System.Windows.Forms.Label lblReport3_q1_3;
        private System.Windows.Forms.Label lblReport3_q1_2;
        private System.Windows.Forms.Label lblReport3_q1_1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblReport3_q4_4_Value;
        private System.Windows.Forms.Label lblReport3_q4_3_Value;
        private System.Windows.Forms.Label lblReport3_q4_2_Value;
        private System.Windows.Forms.Label lblReport3_q4_1_Value;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblReport3_q3_4_Value;
        private System.Windows.Forms.Label lblReport3_q3_3_Value;
        private System.Windows.Forms.Label lblReport3_q3_2_Value;
        private System.Windows.Forms.Label lblReport3_q3_1_Value;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label lblReport3_q2_4_Value;
        private System.Windows.Forms.Label lblReport3_q2_3_Value;
        private System.Windows.Forms.Label lblReport3_q2_2_Value;
        private System.Windows.Forms.Label lblReport3_q2_1_Value;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtReport3_q1_F2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtReport3_q1_F1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtReport3_q4_F2;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtReport3_q4_F1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtReport3_q3_F2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtReport3_q3_F1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtReport3_q2_F2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtReport3_q2_F1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPrsFullName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesIdPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesIdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesRoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesHardware;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesKeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesHoursWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesDateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesContactEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesContactOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesNameFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesNameLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesNameFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesNameMiddle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesDateHired;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEmployeesDateDismissed;
        private System.Windows.Forms.TextBox txtPrsDateBirth;
        private System.Windows.Forms.TextBox txtPrsDateDismissed;
        private System.Windows.Forms.TextBox txtPrsDateHired;
    }
}


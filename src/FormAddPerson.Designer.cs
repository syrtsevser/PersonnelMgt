
namespace PersonnelMgt
{
    partial class FormAddPerson
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
            this.lblEditingExisting = new System.Windows.Forms.Label();
            this.btnSelectExistingPerson = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.btnSelectDept = new System.Windows.Forms.Button();
            this.btnSelectOrg = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnDiscardExistingInfo = new System.Windows.Forms.Button();
            this.panelEditingExistingIcon = new System.Windows.Forms.Panel();
            this.numericHoursWeek = new System.Windows.Forms.NumericUpDown();
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
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Организация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Департамент";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Дата рождения";
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateBirth.Checked = false;
            this.dtpDateBirth.CustomFormat = "dd.MM.yyyy";
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBirth.Location = new System.Drawing.Point(515, 21);
            this.dtpDateBirth.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpDateBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.ShowCheckBox = true;
            this.dtpDateBirth.Size = new System.Drawing.Size(158, 22);
            this.dtpDateBirth.TabIndex = 14;
            // 
            // dtpDateHired
            // 
            this.dtpDateHired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateHired.CustomFormat = "dd.MM.yyyy";
            this.dtpDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateHired.Location = new System.Drawing.Point(515, 49);
            this.dtpDateHired.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpDateHired.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateHired.Name = "dtpDateHired";
            this.dtpDateHired.ShowCheckBox = true;
            this.dtpDateHired.Size = new System.Drawing.Size(158, 22);
            this.dtpDateHired.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Принят";
            // 
            // dtpDateDismissed
            // 
            this.dtpDateDismissed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateDismissed.Checked = false;
            this.dtpDateDismissed.CustomFormat = "dd.MM.yyyy";
            this.dtpDateDismissed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDismissed.Location = new System.Drawing.Point(515, 77);
            this.dtpDateDismissed.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpDateDismissed.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateDismissed.Name = "dtpDateDismissed";
            this.dtpDateDismissed.ShowCheckBox = true;
            this.dtpDateDismissed.Size = new System.Drawing.Size(158, 22);
            this.dtpDateDismissed.TabIndex = 16;
            this.dtpDateDismissed.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Уволен";
            // 
            // txtOtherContacts
            // 
            this.txtOtherContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherContacts.Location = new System.Drawing.Point(117, 332);
            this.txtOtherContacts.Multiline = true;
            this.txtOtherContacts.Name = "txtOtherContacts";
            this.txtOtherContacts.Size = new System.Drawing.Size(214, 45);
            this.txtOtherContacts.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "Другая \r\nсвязь\r\n";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(117, 304);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Почта";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Телефон";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(117, 394);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(556, 55);
            this.txtComment.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 397);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Комментарий";
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosition.Location = new System.Drawing.Point(117, 206);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(214, 22);
            this.txtPosition.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Помещение";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Часы / неделя";
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtPhone.Location = new System.Drawing.Point(117, 276);
            this.mtxtPhone.Mask = "#9 (999) 900 - 0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(214, 22);
            this.mtxtPhone.TabIndex = 11;
            this.mtxtPhone.Text = "+7";
            this.mtxtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbOrg
            // 
            this.cmbOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrg.FormattingEnabled = true;
            this.cmbOrg.Location = new System.Drawing.Point(117, 122);
            this.cmbOrg.Name = "cmbOrg";
            this.cmbOrg.Size = new System.Drawing.Size(214, 24);
            this.cmbOrg.TabIndex = 3;
            this.cmbOrg.SelectedIndexChanged += new System.EventHandler(this.cmbOrg_SelectedIndexChanged);
            // 
            // cmbDept
            // 
            this.cmbDept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(117, 150);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(214, 24);
            this.cmbDept.TabIndex = 5;
            // 
            // cmbRoom
            // 
            this.cmbRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(117, 178);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(214, 24);
            this.cmbRoom.TabIndex = 7;
            // 
            // lblEditingExisting
            // 
            this.lblEditingExisting.AutoSize = true;
            this.lblEditingExisting.Location = new System.Drawing.Point(58, 474);
            this.lblEditingExisting.Name = "lblEditingExisting";
            this.lblEditingExisting.Size = new System.Drawing.Size(262, 16);
            this.lblEditingExisting.TabIndex = 48;
            this.lblEditingExisting.Text = "Редактирование существующей личности";
            this.lblEditingExisting.Visible = false;
            // 
            // btnSelectExistingPerson
            // 
            this.btnSelectExistingPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectExistingPerson.Image = global::PersonnelMgt.Properties.Resources.Search_16x;
            this.btnSelectExistingPerson.Location = new System.Drawing.Point(342, 20);
            this.btnSelectExistingPerson.Name = "btnSelectExistingPerson";
            this.btnSelectExistingPerson.Size = new System.Drawing.Size(25, 23);
            this.btnSelectExistingPerson.TabIndex = 6;
            this.toolTips.SetToolTip(this.btnSelectExistingPerson, "Выбрать бывшего сотрудника");
            this.btnSelectExistingPerson.UseVisualStyleBackColor = true;
            this.btnSelectExistingPerson.Click += new System.EventHandler(this.btnSelectExistingPerson_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::PersonnelMgt.Properties.Resources.Cancel_16x;
            this.btnCancel.Location = new System.Drawing.Point(432, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 31);
            this.btnCancel.TabIndex = 19;
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
            this.btnAccept.Location = new System.Drawing.Point(560, 466);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(113, 31);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "Добавить";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectRoom.Image = global::PersonnelMgt.Properties.Resources.Edit_16x;
            this.btnSelectRoom.Location = new System.Drawing.Point(342, 178);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(25, 23);
            this.btnSelectRoom.TabIndex = 8;
            this.toolTips.SetToolTip(this.btnSelectRoom, "Выбрать");
            this.btnSelectRoom.UseVisualStyleBackColor = true;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // btnSelectDept
            // 
            this.btnSelectDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDept.Image = global::PersonnelMgt.Properties.Resources.Edit_16x;
            this.btnSelectDept.Location = new System.Drawing.Point(342, 150);
            this.btnSelectDept.Name = "btnSelectDept";
            this.btnSelectDept.Size = new System.Drawing.Size(25, 23);
            this.btnSelectDept.TabIndex = 6;
            this.toolTips.SetToolTip(this.btnSelectDept, "Выбрать");
            this.btnSelectDept.UseVisualStyleBackColor = true;
            this.btnSelectDept.Click += new System.EventHandler(this.btnSelectDept_Click);
            // 
            // btnSelectOrg
            // 
            this.btnSelectOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectOrg.Enabled = false;
            this.btnSelectOrg.Image = global::PersonnelMgt.Properties.Resources.Edit_16x;
            this.btnSelectOrg.Location = new System.Drawing.Point(342, 122);
            this.btnSelectOrg.Name = "btnSelectOrg";
            this.btnSelectOrg.Size = new System.Drawing.Size(25, 23);
            this.btnSelectOrg.TabIndex = 4;
            this.toolTips.SetToolTip(this.btnSelectOrg, "Выбрать");
            this.btnSelectOrg.UseVisualStyleBackColor = true;
            // 
            // btnDiscardExistingInfo
            // 
            this.btnDiscardExistingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscardExistingInfo.Image = global::PersonnelMgt.Properties.Resources.Cancel_16x;
            this.btnDiscardExistingInfo.Location = new System.Drawing.Point(342, 48);
            this.btnDiscardExistingInfo.Name = "btnDiscardExistingInfo";
            this.btnDiscardExistingInfo.Size = new System.Drawing.Size(25, 23);
            this.btnDiscardExistingInfo.TabIndex = 7;
            this.toolTips.SetToolTip(this.btnDiscardExistingInfo, "Отменить редактирование");
            this.btnDiscardExistingInfo.UseVisualStyleBackColor = true;
            this.btnDiscardExistingInfo.Visible = false;
            this.btnDiscardExistingInfo.Click += new System.EventHandler(this.btnDiscardExistingInfo_Click);
            // 
            // panelEditingExistingIcon
            // 
            this.panelEditingExistingIcon.Location = new System.Drawing.Point(21, 466);
            this.panelEditingExistingIcon.Name = "panelEditingExistingIcon";
            this.panelEditingExistingIcon.Size = new System.Drawing.Size(31, 31);
            this.panelEditingExistingIcon.TabIndex = 50;
            this.panelEditingExistingIcon.Visible = false;
            // 
            // numericHoursWeek
            // 
            this.numericHoursWeek.Location = new System.Drawing.Point(117, 235);
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
            this.numericHoursWeek.TabIndex = 10;
            // 
            // FormAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 517);
            this.Controls.Add(this.numericHoursWeek);
            this.Controls.Add(this.panelEditingExistingIcon);
            this.Controls.Add(this.btnDiscardExistingInfo);
            this.Controls.Add(this.lblEditingExisting);
            this.Controls.Add(this.btnSelectExistingPerson);
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
            this.Name = "FormAddPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить сотрудника";
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
        private System.Windows.Forms.Button btnSelectExistingPerson;
        private System.Windows.Forms.Label lblEditingExisting;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button btnDiscardExistingInfo;
        private System.Windows.Forms.Panel panelEditingExistingIcon;
        private System.Windows.Forms.NumericUpDown numericHoursWeek;
    }
}
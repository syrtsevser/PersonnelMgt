
namespace PersonnelMgt
{
    partial class FormSelectPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.dgvcPeopleIdPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPeopleNameLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPeopleNameFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPeopleNameMiddle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPeopleDateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPeopleContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPeopleEverWorked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcPeopleWorksNow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.cmbFilterHasWorked = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Организация:";
            // 
            // cmbOrg
            // 
            this.cmbOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrg.FormattingEnabled = true;
            this.cmbOrg.Location = new System.Drawing.Point(349, 36);
            this.cmbOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOrg.Name = "cmbOrg";
            this.cmbOrg.Size = new System.Drawing.Size(218, 24);
            this.cmbOrg.TabIndex = 5;
            this.cmbOrg.SelectedIndexChanged += new System.EventHandler(this.cmbOrg_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Выбрать человека:";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcPeopleIdPerson,
            this.dgvcPeopleNameLast,
            this.dgvcPeopleNameFirst,
            this.dgvcPeopleNameMiddle,
            this.dgvcPeopleDateBirth,
            this.dgvcPeopleContactPhone,
            this.dgvcPeopleEverWorked,
            this.dgvcPeopleWorksNow});
            this.dgvPeople.Location = new System.Drawing.Point(12, 94);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersVisible = false;
            this.dgvPeople.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(766, 277);
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeople_CellDoubleClick);
            // 
            // dgvcPeopleIdPerson
            // 
            this.dgvcPeopleIdPerson.DataPropertyName = "id_person";
            this.dgvcPeopleIdPerson.HeaderText = "ID_PERSON";
            this.dgvcPeopleIdPerson.Name = "dgvcPeopleIdPerson";
            this.dgvcPeopleIdPerson.ReadOnly = true;
            this.dgvcPeopleIdPerson.Visible = false;
            // 
            // dgvcPeopleNameLast
            // 
            this.dgvcPeopleNameLast.DataPropertyName = "name_last";
            this.dgvcPeopleNameLast.HeaderText = "Фамилия";
            this.dgvcPeopleNameLast.MinimumWidth = 70;
            this.dgvcPeopleNameLast.Name = "dgvcPeopleNameLast";
            this.dgvcPeopleNameLast.ReadOnly = true;
            // 
            // dgvcPeopleNameFirst
            // 
            this.dgvcPeopleNameFirst.DataPropertyName = "name_first";
            this.dgvcPeopleNameFirst.HeaderText = "Имя";
            this.dgvcPeopleNameFirst.MinimumWidth = 70;
            this.dgvcPeopleNameFirst.Name = "dgvcPeopleNameFirst";
            this.dgvcPeopleNameFirst.ReadOnly = true;
            // 
            // dgvcPeopleNameMiddle
            // 
            this.dgvcPeopleNameMiddle.DataPropertyName = "name_middle";
            this.dgvcPeopleNameMiddle.HeaderText = "Отчество";
            this.dgvcPeopleNameMiddle.MinimumWidth = 80;
            this.dgvcPeopleNameMiddle.Name = "dgvcPeopleNameMiddle";
            this.dgvcPeopleNameMiddle.ReadOnly = true;
            // 
            // dgvcPeopleDateBirth
            // 
            this.dgvcPeopleDateBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcPeopleDateBirth.DataPropertyName = "date_birth";
            this.dgvcPeopleDateBirth.HeaderText = "Дата рождения";
            this.dgvcPeopleDateBirth.MinimumWidth = 100;
            this.dgvcPeopleDateBirth.Name = "dgvcPeopleDateBirth";
            this.dgvcPeopleDateBirth.ReadOnly = true;
            this.dgvcPeopleDateBirth.Width = 114;
            // 
            // dgvcPeopleContactPhone
            // 
            this.dgvcPeopleContactPhone.DataPropertyName = "contact_phone";
            this.dgvcPeopleContactPhone.HeaderText = "Телефон";
            this.dgvcPeopleContactPhone.MinimumWidth = 70;
            this.dgvcPeopleContactPhone.Name = "dgvcPeopleContactPhone";
            this.dgvcPeopleContactPhone.ReadOnly = true;
            // 
            // dgvcPeopleEverWorked
            // 
            this.dgvcPeopleEverWorked.DataPropertyName = "ever_worked";
            this.dgvcPeopleEverWorked.HeaderText = "Ранее работал";
            this.dgvcPeopleEverWorked.Name = "dgvcPeopleEverWorked";
            this.dgvcPeopleEverWorked.ReadOnly = true;
            this.dgvcPeopleEverWorked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvcPeopleWorksNow
            // 
            this.dgvcPeopleWorksNow.DataPropertyName = "working_now";
            this.dgvcPeopleWorksNow.HeaderText = "Сейчас работает";
            this.dgvcPeopleWorksNow.Name = "dgvcPeopleWorksNow";
            this.dgvcPeopleWorksNow.ReadOnly = true;
            this.dgvcPeopleWorksNow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Фамилия:";
            // 
            // txtFilterName
            // 
            this.txtFilterName.Location = new System.Drawing.Point(18, 38);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(243, 22);
            this.txtFilterName.TabIndex = 3;
            this.txtFilterName.TextChanged += new System.EventHandler(this.txtFilterName_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::PersonnelMgt.Properties.Resources.Cancel_16x;
            this.btnCancel.Location = new System.Drawing.Point(537, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Image = global::PersonnelMgt.Properties.Resources.Checkmark_16x;
            this.btnSelect.Location = new System.Drawing.Point(665, 391);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 31);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Image = global::PersonnelMgt.Properties.Resources.Cancel_16x;
            this.btnResetFilter.Location = new System.Drawing.Point(267, 38);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(23, 23);
            this.btnResetFilter.TabIndex = 4;
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // cmbFilterHasWorked
            // 
            this.cmbFilterHasWorked.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterHasWorked.FormattingEnabled = true;
            this.cmbFilterHasWorked.Items.AddRange(new object[] {
            " <сбросить>",
            "Ранее не работал",
            "Ранее работал",
            "Сейчас работает"});
            this.cmbFilterHasWorked.Location = new System.Drawing.Point(587, 36);
            this.cmbFilterHasWorked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFilterHasWorked.Name = "cmbFilterHasWorked";
            this.cmbFilterHasWorked.Size = new System.Drawing.Size(148, 24);
            this.cmbFilterHasWorked.TabIndex = 6;
            this.cmbFilterHasWorked.SelectedIndexChanged += new System.EventHandler(this.cmbFilterHasWorked_SelectedIndexChanged);
            // 
            // FormSelectPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 440);
            this.Controls.Add(this.cmbFilterHasWorked);
            this.Controls.Add(this.btnResetFilter);
            this.Controls.Add(this.txtFilterName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOrg);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSelectPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбрать бывшего сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPeopleIdPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPeopleNameLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPeopleNameFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPeopleNameMiddle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPeopleDateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPeopleContactPhone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcPeopleEverWorked;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcPeopleWorksNow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.ComboBox cmbFilterHasWorked;
    }
}
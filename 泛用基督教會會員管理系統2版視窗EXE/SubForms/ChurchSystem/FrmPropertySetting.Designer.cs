namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.ChurchSystem
{
    partial class FrmPropertySetting
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
            tabControl1 = new TabControl();
            TbpRoles = new TabPage();
            DgvRoles = new DataGridView();
            V1 = new DataGridViewTextBoxColumn();
            N1 = new DataGridViewTextBoxColumn();
            A1 = new DataGridViewTextBoxColumn();
            TbpMeetingSetting = new TabPage();
            DgvMeetingTypes = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            TbpDedicationSetting = new TabPage();
            DgvDedicationTypes = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DeleteButton = new Button();
            BtnEdit = new Button();
            BtnAdd = new Button();
            tabControl1.SuspendLayout();
            TbpRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRoles).BeginInit();
            TbpMeetingSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMeetingTypes).BeginInit();
            TbpDedicationSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDedicationTypes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(TbpRoles);
            tabControl1.Controls.Add(TbpMeetingSetting);
            tabControl1.Controls.Add(TbpDedicationSetting);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(717, 343);
            tabControl1.TabIndex = 12;
            // 
            // TbpRoles
            // 
            TbpRoles.Controls.Add(DgvRoles);
            TbpRoles.Location = new Point(4, 39);
            TbpRoles.Name = "TbpRoles";
            TbpRoles.Padding = new Padding(3);
            TbpRoles.Size = new Size(709, 300);
            TbpRoles.TabIndex = 2;
            TbpRoles.Text = "教友角色";
            TbpRoles.UseVisualStyleBackColor = true;
            // 
            // DgvRoles
            // 
            DgvRoles.AllowUserToAddRows = false;
            DgvRoles.AllowUserToDeleteRows = false;
            DgvRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRoles.Columns.AddRange(new DataGridViewColumn[] { V1, N1, A1 });
            DgvRoles.Location = new Point(6, 6);
            DgvRoles.Name = "DgvRoles";
            DgvRoles.ReadOnly = true;
            DgvRoles.RowHeadersWidth = 62;
            DgvRoles.Size = new Size(697, 288);
            DgvRoles.TabIndex = 0;
            // 
            // V1
            // 
            V1.HeaderText = "角色代號";
            V1.MinimumWidth = 8;
            V1.Name = "V1";
            V1.ReadOnly = true;
            V1.Width = 150;
            // 
            // N1
            // 
            N1.HeaderText = "角色名稱";
            N1.MinimumWidth = 8;
            N1.Name = "N1";
            N1.ReadOnly = true;
            N1.Width = 150;
            // 
            // A1
            // 
            A1.HeaderText = "系統管理者權限";
            A1.MinimumWidth = 8;
            A1.Name = "A1";
            A1.ReadOnly = true;
            A1.Width = 250;
            // 
            // TbpMeetingSetting
            // 
            TbpMeetingSetting.Controls.Add(DgvMeetingTypes);
            TbpMeetingSetting.Location = new Point(4, 39);
            TbpMeetingSetting.Name = "TbpMeetingSetting";
            TbpMeetingSetting.Padding = new Padding(3);
            TbpMeetingSetting.Size = new Size(709, 300);
            TbpMeetingSetting.TabIndex = 0;
            TbpMeetingSetting.Text = "聚會類型";
            TbpMeetingSetting.UseVisualStyleBackColor = true;
            // 
            // DgvMeetingTypes
            // 
            DgvMeetingTypes.AllowUserToAddRows = false;
            DgvMeetingTypes.AllowUserToDeleteRows = false;
            DgvMeetingTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvMeetingTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMeetingTypes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            DgvMeetingTypes.Location = new Point(6, 6);
            DgvMeetingTypes.Name = "DgvMeetingTypes";
            DgvMeetingTypes.ReadOnly = true;
            DgvMeetingTypes.RowHeadersWidth = 62;
            DgvMeetingTypes.Size = new Size(697, 288);
            DgvMeetingTypes.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "聚會類型代號";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "聚會類型名稱";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // TbpDedicationSetting
            // 
            TbpDedicationSetting.Controls.Add(DgvDedicationTypes);
            TbpDedicationSetting.Location = new Point(4, 39);
            TbpDedicationSetting.Name = "TbpDedicationSetting";
            TbpDedicationSetting.Padding = new Padding(3);
            TbpDedicationSetting.Size = new Size(709, 300);
            TbpDedicationSetting.TabIndex = 1;
            TbpDedicationSetting.Text = "奉獻類型";
            TbpDedicationSetting.UseVisualStyleBackColor = true;
            // 
            // DgvDedicationTypes
            // 
            DgvDedicationTypes.AllowUserToAddRows = false;
            DgvDedicationTypes.AllowUserToDeleteRows = false;
            DgvDedicationTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvDedicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDedicationTypes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            DgvDedicationTypes.Location = new Point(6, 6);
            DgvDedicationTypes.Name = "DgvDedicationTypes";
            DgvDedicationTypes.ReadOnly = true;
            DgvDedicationTypes.RowHeadersWidth = 62;
            DgvDedicationTypes.Size = new Size(697, 288);
            DgvDedicationTypes.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "奉獻類型代號";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "奉獻類型名稱";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteButton.Location = new Point(735, 112);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(108, 44);
            DeleteButton.TabIndex = 15;
            DeleteButton.Text = "刪除";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Location = new Point(735, 62);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(108, 44);
            BtnEdit.TabIndex = 14;
            BtnEdit.Text = "修改";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdd.Location = new Point(735, 12);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(108, 44);
            BtnAdd.TabIndex = 13;
            BtnAdd.Text = "新增";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // FrmPropertySetting
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 367);
            Controls.Add(DeleteButton);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "FrmPropertySetting";
            Text = "屬性設定";
            tabControl1.ResumeLayout(false);
            TbpRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvRoles).EndInit();
            TbpMeetingSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvMeetingTypes).EndInit();
            TbpDedicationSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDedicationTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage TbpMeetingSetting;
        private TabPage TbpDedicationSetting;
        private Button DeleteButton;
        private Button BtnEdit;
        private Button BtnAdd;
        private TabPage TbpRoles;
        private DataGridView DgvRoles;
        private DataGridViewTextBoxColumn V1;
        private DataGridViewTextBoxColumn N1;
        private DataGridViewTextBoxColumn A1;
        private DataGridView DgvMeetingTypes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView DgvDedicationTypes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
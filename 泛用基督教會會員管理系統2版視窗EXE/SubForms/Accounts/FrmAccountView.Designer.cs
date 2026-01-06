namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.Accounts
{
    partial class FrmAccountView
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
            BtnAdd = new Button();
            BtnEdit = new Button();
            DgvAccountView = new DataGridView();
            MemberID = new DataGridViewTextBoxColumn();
            MemberName = new DataGridViewTextBoxColumn();
            MemberGender = new DataGridViewTextBoxColumn();
            MemberBirth = new DataGridViewTextBoxColumn();
            MemberPhone = new DataGridViewTextBoxColumn();
            MemberEmail = new DataGridViewTextBoxColumn();
            MemberAddr = new DataGridViewTextBoxColumn();
            MemberBaptised = new DataGridViewTextBoxColumn();
            Editor = new DataGridViewTextBoxColumn();
            EditorDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvAccountView).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdd.Location = new Point(869, 12);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(108, 44);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "新增";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Location = new Point(869, 62);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(108, 44);
            BtnEdit.TabIndex = 1;
            BtnEdit.Text = "修改";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // DgvAccountView
            // 
            DgvAccountView.AllowUserToAddRows = false;
            DgvAccountView.AllowUserToDeleteRows = false;
            DgvAccountView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvAccountView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAccountView.Columns.AddRange(new DataGridViewColumn[] { MemberID, MemberName, MemberGender, MemberBirth, MemberPhone, MemberEmail, MemberAddr, MemberBaptised, Editor, EditorDate });
            DgvAccountView.Location = new Point(12, 12);
            DgvAccountView.Name = "DgvAccountView";
            DgvAccountView.ReadOnly = true;
            DgvAccountView.RowHeadersWidth = 51;
            DgvAccountView.Size = new Size(851, 440);
            DgvAccountView.TabIndex = 2;
            // 
            // MemberID
            // 
            MemberID.HeaderText = "帳號";
            MemberID.MinimumWidth = 6;
            MemberID.Name = "MemberID";
            MemberID.ReadOnly = true;
            MemberID.Width = 125;
            // 
            // MemberName
            // 
            MemberName.HeaderText = "姓名";
            MemberName.MinimumWidth = 6;
            MemberName.Name = "MemberName";
            MemberName.ReadOnly = true;
            MemberName.Width = 125;
            // 
            // MemberGender
            // 
            MemberGender.HeaderText = "性別";
            MemberGender.MinimumWidth = 6;
            MemberGender.Name = "MemberGender";
            MemberGender.ReadOnly = true;
            MemberGender.Width = 125;
            // 
            // MemberBirth
            // 
            MemberBirth.HeaderText = "生日";
            MemberBirth.MinimumWidth = 6;
            MemberBirth.Name = "MemberBirth";
            MemberBirth.ReadOnly = true;
            MemberBirth.Width = 125;
            // 
            // MemberPhone
            // 
            MemberPhone.HeaderText = "電話";
            MemberPhone.MinimumWidth = 6;
            MemberPhone.Name = "MemberPhone";
            MemberPhone.ReadOnly = true;
            MemberPhone.Width = 150;
            // 
            // MemberEmail
            // 
            MemberEmail.HeaderText = "電子郵件信箱";
            MemberEmail.MinimumWidth = 6;
            MemberEmail.Name = "MemberEmail";
            MemberEmail.ReadOnly = true;
            MemberEmail.Width = 250;
            // 
            // MemberAddr
            // 
            MemberAddr.HeaderText = "住址";
            MemberAddr.MinimumWidth = 6;
            MemberAddr.Name = "MemberAddr";
            MemberAddr.ReadOnly = true;
            MemberAddr.Width = 250;
            // 
            // MemberBaptised
            // 
            MemberBaptised.HeaderText = "受洗？";
            MemberBaptised.MinimumWidth = 6;
            MemberBaptised.Name = "MemberBaptised";
            MemberBaptised.ReadOnly = true;
            MemberBaptised.Width = 125;
            // 
            // Editor
            // 
            Editor.HeaderText = "修改者";
            Editor.MinimumWidth = 6;
            Editor.Name = "Editor";
            Editor.ReadOnly = true;
            Editor.Width = 125;
            // 
            // EditorDate
            // 
            EditorDate.HeaderText = "修改日期";
            EditorDate.MinimumWidth = 6;
            EditorDate.Name = "EditorDate";
            EditorDate.ReadOnly = true;
            EditorDate.Width = 125;
            // 
            // FrmAccountView
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 464);
            Controls.Add(DgvAccountView);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            Name = "FrmAccountView";
            Text = "教友資料";
            ((System.ComponentModel.ISupportInitialize)DgvAccountView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAdd;
        private Button BtnEdit;
        private DataGridView DgvAccountView;
        private DataGridViewTextBoxColumn MemberID;
        private DataGridViewTextBoxColumn MemberName;
        private DataGridViewTextBoxColumn MemberGender;
        private DataGridViewTextBoxColumn MemberBirth;
        private DataGridViewTextBoxColumn MemberPhone;
        private DataGridViewTextBoxColumn MemberEmail;
        private DataGridViewTextBoxColumn MemberAddr;
        private DataGridViewTextBoxColumn MemberBaptised;
        private DataGridViewTextBoxColumn Editor;
        private DataGridViewTextBoxColumn EditorDate;
    }
}
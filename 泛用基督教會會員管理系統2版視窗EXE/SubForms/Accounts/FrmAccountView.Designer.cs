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
            DgvAccountView.Location = new Point(12, 12);
            DgvAccountView.Name = "DgvAccountView";
            DgvAccountView.ReadOnly = true;
            DgvAccountView.RowHeadersWidth = 51;
            DgvAccountView.Size = new Size(851, 440);
            DgvAccountView.TabIndex = 2;
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmAccountView";
            Text = "教友資料";
            ((System.ComponentModel.ISupportInitialize)DgvAccountView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAdd;
        private Button BtnEdit;
        private DataGridView DgvAccountView;
    }
}
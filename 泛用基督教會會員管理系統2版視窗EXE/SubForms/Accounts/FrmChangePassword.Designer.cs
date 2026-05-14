namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.Accounts
{
    partial class FrmChangePassword
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
            label1 = new Label();
            TxtID = new TextBox();
            TxtOldPassword = new TextBox();
            label2 = new Label();
            TxtConfirmNewPassword = new TextBox();
            TxtNewPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            BtnCancel = new Button();
            BtnConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 68);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "帳號";
            // 
            // TxtID
            // 
            TxtID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtID.Location = new Point(128, 65);
            TxtID.Name = "TxtID";
            TxtID.ReadOnly = true;
            TxtID.Size = new Size(460, 33);
            TxtID.TabIndex = 1;
            // 
            // TxtOldPassword
            // 
            TxtOldPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtOldPassword.Location = new Point(128, 116);
            TxtOldPassword.Name = "TxtOldPassword";
            TxtOldPassword.Size = new Size(460, 33);
            TxtOldPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 119);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 3;
            label2.Text = "舊密碼";
            // 
            // TxtConfirmNewPassword
            // 
            TxtConfirmNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtConfirmNewPassword.Location = new Point(128, 215);
            TxtConfirmNewPassword.Name = "TxtConfirmNewPassword";
            TxtConfirmNewPassword.Size = new Size(460, 33);
            TxtConfirmNewPassword.TabIndex = 5;
            // 
            // TxtNewPassword
            // 
            TxtNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtNewPassword.Location = new Point(128, 164);
            TxtNewPassword.Name = "TxtNewPassword";
            TxtNewPassword.Size = new Size(460, 33);
            TxtNewPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 167);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 6;
            label3.Text = "新密碼";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 218);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 7;
            label4.Text = "確認新密碼";
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(494, 300);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 61);
            BtnCancel.TabIndex = 9;
            BtnCancel.Text = "取消";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConfirm.Location = new Point(394, 300);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 61);
            BtnConfirm.TabIndex = 8;
            BtnConfirm.Text = "確認";
            BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // FrmChangePassword
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 373);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtConfirmNewPassword);
            Controls.Add(TxtNewPassword);
            Controls.Add(label2);
            Controls.Add(TxtOldPassword);
            Controls.Add(TxtID);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmChangePassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "變更密碼";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtID;
        private TextBox TxtOldPassword;
        private Label label2;
        private TextBox TxtConfirmNewPassword;
        private TextBox TxtNewPassword;
        private Label label3;
        private Label label4;
        private Button BtnCancel;
        private Button BtnConfirm;
    }
}
namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.Accounts
{
    partial class FrmAccountEditor
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
            BtnCancel = new Button();
            BtnConfirm = new Button();
            label1 = new Label();
            TxtLoginID = new TextBox();
            label3 = new Label();
            TxtName = new TextBox();
            label2 = new Label();
            RdoMan = new RadioButton();
            RdoWoman = new RadioButton();
            label4 = new Label();
            DtpBirthday = new DateTimePicker();
            label5 = new Label();
            TxtPhone = new TextBox();
            TxtEMail = new TextBox();
            label6 = new Label();
            TxtHomeAddress = new TextBox();
            label7 = new Label();
            ChkBaptised = new CheckBox();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(737, 262);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 61);
            BtnCancel.TabIndex = 7;
            BtnCancel.Text = "取消";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConfirm.Location = new Point(637, 262);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 61);
            BtnConfirm.TabIndex = 6;
            BtnConfirm.Text = "確認";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 24);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 8;
            label1.Text = "帳號";
            // 
            // TxtLoginID
            // 
            TxtLoginID.Location = new Point(163, 21);
            TxtLoginID.Name = "TxtLoginID";
            TxtLoginID.Size = new Size(251, 33);
            TxtLoginID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 27);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 12;
            label3.Text = "姓名";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(583, 24);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(251, 33);
            TxtName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 63);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 14;
            label2.Text = "性別";
            // 
            // RdoMan
            // 
            RdoMan.AutoSize = true;
            RdoMan.Checked = true;
            RdoMan.Location = new Point(163, 63);
            RdoMan.Name = "RdoMan";
            RdoMan.Size = new Size(53, 29);
            RdoMan.TabIndex = 15;
            RdoMan.TabStop = true;
            RdoMan.Text = "男";
            RdoMan.UseVisualStyleBackColor = true;
            // 
            // RdoWoman
            // 
            RdoWoman.AutoSize = true;
            RdoWoman.Location = new Point(222, 63);
            RdoWoman.Name = "RdoWoman";
            RdoWoman.Size = new Size(53, 29);
            RdoWoman.TabIndex = 16;
            RdoWoman.Text = "女";
            RdoWoman.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 67);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 17;
            label4.Text = "出生日期";
            // 
            // DtpBirthday
            // 
            DtpBirthday.Location = new Point(583, 63);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(251, 33);
            DtpBirthday.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(250, 25);
            label5.TabIndex = 19;
            label5.Text = "連絡電話(住家或手機均可))";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(268, 102);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(566, 33);
            TxtPhone.TabIndex = 20;
            // 
            // TxtEMail
            // 
            TxtEMail.Location = new Point(268, 141);
            TxtEMail.Name = "TxtEMail";
            TxtEMail.Size = new Size(566, 33);
            TxtEMail.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 144);
            label6.Name = "label6";
            label6.Size = new Size(195, 25);
            label6.TabIndex = 22;
            label6.Text = "電子郵件信箱(EMail)";
            // 
            // TxtHomeAddress
            // 
            TxtHomeAddress.Location = new Point(268, 180);
            TxtHomeAddress.Name = "TxtHomeAddress";
            TxtHomeAddress.Size = new Size(566, 33);
            TxtHomeAddress.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 183);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 24;
            label7.Text = "住家地址";
            // 
            // ChkBaptised
            // 
            ChkBaptised.AutoSize = true;
            ChkBaptised.Location = new Point(268, 219);
            ChkBaptised.Name = "ChkBaptised";
            ChkBaptised.Size = new Size(94, 29);
            ChkBaptised.TabIndex = 25;
            ChkBaptised.Text = "已受洗";
            ChkBaptised.UseVisualStyleBackColor = true;
            // 
            // FrmAccountEditor
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 335);
            Controls.Add(ChkBaptised);
            Controls.Add(label7);
            Controls.Add(TxtHomeAddress);
            Controls.Add(label6);
            Controls.Add(TxtEMail);
            Controls.Add(TxtPhone);
            Controls.Add(label5);
            Controls.Add(DtpBirthday);
            Controls.Add(label4);
            Controls.Add(RdoWoman);
            Controls.Add(RdoMan);
            Controls.Add(label2);
            Controls.Add(TxtName);
            Controls.Add(label3);
            Controls.Add(TxtLoginID);
            Controls.Add(label1);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Font = new Font("Microsoft JhengHei UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAccountEditor";
            ShowIcon = false;
            Text = "FrmAccountEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancel;
        private Button BtnConfirm;
        private Label label1;
        private TextBox TxtLoginID;
        private Label label3;
        private TextBox TxtName;
        private Label label2;
        private RadioButton RdoMan;
        private RadioButton RdoWoman;
        private Label label4;
        private DateTimePicker DtpBirthday;
        private Label label5;
        private TextBox TxtPhone;
        private TextBox TxtEMail;
        private Label label6;
        private TextBox TxtHomeAddress;
        private Label label7;
        private CheckBox ChkBaptised;
    }
}
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
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(784, 400);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 61);
            BtnCancel.TabIndex = 7;
            BtnCancel.Text = "取消";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConfirm.Location = new Point(684, 400);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 61);
            BtnConfirm.TabIndex = 6;
            BtnConfirm.Text = "確認";
            BtnConfirm.UseVisualStyleBackColor = true;
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
            // FrmAccountEditor
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 473);
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
    }
}
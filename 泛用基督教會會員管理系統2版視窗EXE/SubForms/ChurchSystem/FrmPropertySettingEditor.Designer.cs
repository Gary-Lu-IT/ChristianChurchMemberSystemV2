namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.ChurchSystem
{
    partial class FrmPropertySettingEditor
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
            TxtPropertyGroupName = new TextBox();
            TxtPropertyValue = new TextBox();
            label2 = new Label();
            TxtPropertyName = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(469, 282);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 61);
            BtnCancel.TabIndex = 11;
            BtnCancel.Text = "取消";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConfirm.Location = new Point(369, 282);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(94, 61);
            BtnConfirm.TabIndex = 10;
            BtnConfirm.Text = "確認";
            BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // TxtPropertyGroupName
            // 
            TxtPropertyGroupName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtPropertyGroupName.Location = new Point(12, 42);
            TxtPropertyGroupName.Name = "TxtPropertyGroupName";
            TxtPropertyGroupName.ReadOnly = true;
            TxtPropertyGroupName.Size = new Size(551, 38);
            TxtPropertyGroupName.TabIndex = 13;
            // 
            // TxtPropertyValue
            // 
            TxtPropertyValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtPropertyValue.Location = new Point(12, 116);
            TxtPropertyValue.Name = "TxtPropertyValue";
            TxtPropertyValue.Size = new Size(551, 38);
            TxtPropertyValue.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 14;
            label2.Text = "label2";
            // 
            // TxtPropertyName
            // 
            TxtPropertyName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtPropertyName.Location = new Point(12, 190);
            TxtPropertyName.Name = "TxtPropertyName";
            TxtPropertyName.Size = new Size(551, 38);
            TxtPropertyName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(81, 30);
            label3.TabIndex = 16;
            label3.Text = "label3";
            // 
            // FrmPropertySettingEditor
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 355);
            Controls.Add(TxtPropertyName);
            Controls.Add(label3);
            Controls.Add(TxtPropertyValue);
            Controls.Add(label2);
            Controls.Add(TxtPropertyGroupName);
            Controls.Add(label1);
            Controls.Add(BtnCancel);
            Controls.Add(BtnConfirm);
            Font = new Font("Microsoft JhengHei UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmPropertySettingEditor";
            Text = "屬性值設定";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancel;
        private Button BtnConfirm;
        private Label label1;
        private TextBox TxtPropertyGroupName;
        private TextBox TxtPropertyValue;
        private Label label2;
        private TextBox TxtPropertyName;
        private Label label3;
    }
}
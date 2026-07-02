namespace 泛用基督教會會員管理系統2版視窗EXE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            TsmiLogin = new ToolStripMenuItem();
            TsmiLogout = new ToolStripMenuItem();
            TsmDataManagement = new ToolStripMenuItem();
            TsmiMemberManager = new ToolStripMenuItem();
            TsmSystemSetting = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            TsslTime = new ToolStripStatusLabel();
            TsslCurrentUser = new ToolStripStatusLabel();
            tmrCurrentTime = new System.Windows.Forms.Timer(components);
            TsmPropertySetting = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TsmiLogin, TsmiLogout, TsmDataManagement, TsmSystemSetting });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(978, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // TsmiLogin
            // 
            TsmiLogin.Name = "TsmiLogin";
            TsmiLogin.Size = new Size(79, 28);
            TsmiLogin.Text = "登入(&I)";
            TsmiLogin.Click += ClickTsmiLogin;
            // 
            // TsmiLogout
            // 
            TsmiLogout.Name = "TsmiLogout";
            TsmiLogout.Size = new Size(89, 28);
            TsmiLogout.Text = "登出(&O)";
            TsmiLogout.Click += ClickTsmiLogout;
            // 
            // TsmDataManagement
            // 
            TsmDataManagement.DropDownItems.AddRange(new ToolStripItem[] { TsmiMemberManager });
            TsmDataManagement.Name = "TsmDataManagement";
            TsmDataManagement.Size = new Size(145, 28);
            TsmDataManagement.Text = "主資料管理(&M)";
            // 
            // TsmiMemberManager
            // 
            TsmiMemberManager.Name = "TsmiMemberManager";
            TsmiMemberManager.Size = new Size(242, 34);
            TsmiMemberManager.Text = "會員資料管理(&A)";
            TsmiMemberManager.Click += TsmiMemberManager_Click;
            // 
            // TsmSystemSetting
            // 
            TsmSystemSetting.DropDownItems.AddRange(new ToolStripItem[] { TsmPropertySetting });
            TsmSystemSetting.Name = "TsmSystemSetting";
            TsmSystemSetting.Size = new Size(120, 28);
            TsmSystemSetting.Text = "系統設定(&S)";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { TsslTime, TsslCurrentUser });
            statusStrip1.Location = new Point(0, 515);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(978, 30);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // TsslTime
            // 
            TsslTime.Name = "TsslTime";
            TsslTime.Size = new Size(192, 23);
            TsslTime.Text = "toolStripStatusLabel1";
            // 
            // TsslCurrentUser
            // 
            TsslCurrentUser.Name = "TsslCurrentUser";
            TsslCurrentUser.Size = new Size(192, 23);
            TsslCurrentUser.Text = "toolStripStatusLabel2";
            // 
            // tmrCurrentTime
            // 
            tmrCurrentTime.Tick += tmrCurrentTime_Tick;
            // 
            // TsmPropertySetting
            // 
            TsmPropertySetting.Name = "TsmPropertySetting";
            TsmPropertySetting.Size = new Size(270, 34);
            TsmPropertySetting.Text = "各種屬性設定(&P)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 545);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "泛用基督教會會員管理系統";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TsmiLogin;
        private ToolStripMenuItem TsmiLogout;
        private ToolStripMenuItem TsmDataManagement;
        private ToolStripMenuItem TsmiMemberManager;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel TsslTime;
        private ToolStripStatusLabel TsslCurrentUser;
        private System.Windows.Forms.Timer tmrCurrentTime;
        private ToolStripMenuItem TsmSystemSetting;
        private ToolStripMenuItem TsmPropertySetting;
    }
}

using 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts;
using 泛用基督教會會員管理系統2版視窗EXE.SubForms.Accounts;

namespace 泛用基督教會會員管理系統2版視窗EXE
{
    public partial class Form1 : Form
    {
        /// <summary>目前登入者資訊</summary>
        private ClsLoginResult? CurrentLogin;
        public Form1()
        {
            InitializeComponent();

            SwitchLoginOutState();
        }
        #region 登入登出
        /// <summary>登入作業</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickTsmiLogin(object sender, EventArgs e)
        {
            FrmLogin FL = new FrmLogin();
            if (FL.ShowDialog(this) == DialogResult.OK)
            {
                CurrentLogin = FL.LoginResult;
                SwitchLoginOutState();
                MessageBox.Show($"歡迎，{CurrentLogin.UserName}！", "登入成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>登出作業</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickTsmiLogout(object sender, EventArgs e)
        {
            if (CurrentLogin != null)
            {
                if (MessageBox.Show("確定要登出目前使用的帳號嗎？", "登出確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CurrentLogin = null;
                    SwitchLoginOutState();
                    MessageBox.Show("已成功登出。", "登出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region 副程式
        /// <summary>切換登入登出選單狀態</summary>
        private void SwitchLoginOutState()
        {
            TsmiLogin.Visible = CurrentLogin == null;
            TsmiLogout.Visible = CurrentLogin != null;
            TsmiMemberManager.Visible = CurrentLogin != null;
        }
        #endregion

        #region 主資料管理
        /// <summary>開啟會員資料視窗</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiMemberManager_Click(object sender, EventArgs e)
        {
            foreach(Form f in MdiChildren)
            {
                if(f is FrmAccountView)
                {
                    f.Activate();
                    return;
                }
            }
            FrmAccountView FAV = new FrmAccountView
            {
                MdiParent = this
            };
            FAV.Show();
        }
        #endregion
    }
}
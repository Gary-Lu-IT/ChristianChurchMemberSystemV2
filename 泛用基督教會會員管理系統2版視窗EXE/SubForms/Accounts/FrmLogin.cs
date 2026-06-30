using System.ComponentModel;
using 泛用基督教會會員管理系統2版DAL.CustomClasses;
using 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts;
using 泛用基督教會會員管理系統2版通用API.DataExaminers;

namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.Accounts
{
    public partial class FrmLogin : Form
    {
        /// <summary>登入帳號</summary>
        public string LoginID
        {
            get
            {
                return TxtLoginID.Text;
            }
        }
        /// <summary>登入者資料</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ClsLoginResult? LoginResult { get; set; } = null;
        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>取消登入</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Close();
        }
        /// <summary>確定登入</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(TxtLoginID.Text)||string.IsNullOrWhiteSpace(TxtPassword.Text))
                {
                    MessageBox.Show("請輸入登入帳號與密碼！", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtLoginID.Focus();
                    return;
                }
                LoginResult=AccountExaminer.Login(new ClsLoginParam
                {
                    UserID=TxtLoginID.Text,
                    Password=TxtPassword.Text
                });
                DialogResult=DialogResult.OK;
                Close();
            }
            catch(ChurchMemberException cex)
            {
                switch (cex.ErrorCode)
                {
                    case SystemReturnMessage.PasswordNotSet:
                        if(MessageBox.Show("此帳號尚未設定密碼,要現在進行設定嗎？", "登入失敗", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmChangePassword FCP = new(TxtLoginID.Text, true);
                            FCP.ShowDialog(this);
                        }
                        else
                        {
                            MessageBox.Show("使用者放棄設定密碼。", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Close();
                        }
                        break;
                    default:
                        MessageBox.Show("登入失敗，錯誤訊息如下：" + Environment.NewLine + cex.Message, "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登入失敗，錯誤訊息如下：" + Environment.NewLine + ex.Message, "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

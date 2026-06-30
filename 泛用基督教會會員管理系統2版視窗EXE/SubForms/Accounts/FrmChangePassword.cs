using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 泛用基督教會會員管理系統2版通用API.DataExaminers;

namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.Accounts
{
    public partial class FrmChangePassword : Form
    {
        /// <summary>是否是新設定密碼</summary>
        private bool NewSetting;
        /// <summary>指定目前要改密碼的使用者，開啟變更密碼視窗</summary>
        /// <param name="CurrentOperator">目前要設定密碼的使用者</param>
        /// <param name="FirstTimeLogin">是否是初次登入</param>
        public FrmChangePassword(string CurrentOperator,bool FirstTimeLogin=true)
        {
            InitializeComponent();

            NewSetting = FirstTimeLogin;
            //如果是初次登入，則不需要輸入舊密碼
            if (FirstTimeLogin)
            {
                label2.Visible = false;
                TxtOldPassword.Visible = false;
            }

            TxtID.Text = CurrentOperator;
        }
        /// <summary>取消鍵。</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>確定鍵。</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {

            if((!NewSetting && string.IsNullOrWhiteSpace(TxtOldPassword.Text))||
                string.IsNullOrWhiteSpace(TxtNewPassword.Text) ||
               string.IsNullOrWhiteSpace(TxtConfirmNewPassword.Text))
            {
                MessageBox.Show("請檢查舊密碼、新密碼、確認新密碼是否都有輸入。", "資料不完整", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AccountExaminer.SetPassword(new 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts.ClsSetPasswordParam()
            {
                UserID = TxtID.Text,
                Password = TxtNewPassword.Text
            });
            MessageBox.Show("成功。稍後請於登入視窗再登入試試看。", "密碼變更/設定", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}

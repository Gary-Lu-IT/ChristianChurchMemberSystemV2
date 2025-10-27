using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
                LoginResult=AccountExaminers.Login(new ClsLoginParam
                {
                    UserID=TxtLoginID.Text,
                    Password=TxtPassword.Text
                });
                MessageBox.Show("登入成功！", "登入成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult=DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("登入失敗，錯誤訊息如下：" + Environment.NewLine + ex.Message, "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

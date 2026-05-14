using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.Accounts
{
    public partial class FrmChangePassword : Form
    {
        /// <summary>指定目前要改密碼的使用者，開啟變更密碼視窗</summary>
        /// <param name="CurrentOperator"></param>
        public FrmChangePassword(string CurrentOperator)
        {
            InitializeComponent();

            TxtID.Text= CurrentOperator;
        }
    }
}

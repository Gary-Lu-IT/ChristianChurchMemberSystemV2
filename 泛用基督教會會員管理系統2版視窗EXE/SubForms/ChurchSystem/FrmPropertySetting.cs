using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.ChurchSystem
{
    public partial class FrmPropertySetting : Form
    {
        public FrmPropertySetting()
        {
            InitializeComponent();
        }
        /// <summary>屬性群組名稱</summary>
        private string[] PropertyItemGroups
        {
            get
            {
                return (from TabPage tb in tabControl1.TabPages
                        select tb.Text).ToArray();
            }
        }
    }
}

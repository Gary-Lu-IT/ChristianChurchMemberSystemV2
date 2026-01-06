using 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts;
using 泛用基督教會會員管理系統2版通用API.DataExaminers;

namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.Accounts
{
    /// <summary>教友(會員)資料編輯視窗</summary>
    public partial class FrmAccountEditor : Form
    {
        #region Private Fields
        /// <summary>資料編輯者</summary>
        private string DataEditor { get; set; } = null!;
        #endregion
        #region Public Properties
        #endregion
        /// <summary>設定要編輯的教友(會員)資料，未傳入視為新增資料。</summary>
        /// <param name="CurrentUser"></param>
        public FrmAccountEditor(string CurrentUser, string TargetMemberID = "")
        {
            InitializeComponent();
            DataEditor = CurrentUser;
            if (string.IsNullOrEmpty(TargetMemberID))
            {
                //新增資料
                this.Text = "新增教友(會員)資料";

                TxtLoginID.Text = string.Empty;
                TxtLoginID.Enabled = true;
                TxtName.Text = string.Empty;
                RdoMan.Checked = true;
                RdoWoman.Checked = false;
                DtpBirthday.Value = DateTime.Now;
                TxtPhone.Text = string.Empty;
                TxtPhone.Text = string.Empty;
                TxtHomeAddress.Text = string.Empty;
            }
            else
            {
                //編輯資料
                this.Text = "編輯教友(會員)資料";
                TxtLoginID.Enabled = false;
            }
        }
        /// <summary>按下確定鍵</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if(!TxtLoginID.Enabled)
            {
                //編輯模式
                AccountExaminer.UpdateMember(new ClsModifyMemberParam
                {
                    MemberID = TxtLoginID.Text.Trim(),
                    Name = TxtName.Text.Trim(),
                    GenderIsMale = RdoMan.Checked,
                    Birthdate = DtpBirthday.Value,
                    PhoneNumber = TxtPhone.Text.Trim(),
                    Email = TxtEMail.Text.Trim(),
                    HomeAddress = TxtHomeAddress.Text.Trim(),
                    IsBaptised = RdoMan.Checked,
                    ModifiedDate = DtpBirthday.Value,
                    ModifiedBy = DataEditor
                });
                MessageBox.Show("修改成功。", "修改成員資料", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                //新增模式
                if (string.IsNullOrWhiteSpace(TxtLoginID.Text) || string.IsNullOrWhiteSpace(TxtName.Text))
                {
                    MessageBox.Show("帳號與姓名必須填寫", "無法新增", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                AccountExaminer.AddMember(new ClsCreateMemberParam
                {
                    MemberID = TxtLoginID.Text.Trim(),
                    Name = TxtName.Text.Trim(),
                    GenderIsMale = RdoMan.Checked,
                    Birthdate = DtpBirthday.Value,
                    PhoneNumber = TxtPhone.Text.Trim(),
                    Email = TxtEMail.Text.Trim(),
                    HomeAddress = TxtHomeAddress.Text.Trim(),
                    IsBaptised = RdoMan.Checked,
                    CreatedDate = DtpBirthday.Value,
                    CreatedBy = DataEditor
                });
                MessageBox.Show("新增成功。", "新增成員資料", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}

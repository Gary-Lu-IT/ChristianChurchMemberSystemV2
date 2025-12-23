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
            }
        }
    }
}

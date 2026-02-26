using 泛用基督教會會員管理系統2版通用API.DataExaminers;
namespace 泛用基督教會會員管理系統2版視窗EXE.SubForms.Accounts
{
    public partial class FrmAccountView : Form
    {
        /// <summary>目前使用者</summary>
        public string CurrentUser { get; }
        public FrmAccountView(string CurrentOperator)
        {
            InitializeComponent();

            CurrentUser = CurrentOperator;
            LoadMemberData();
        }
        #region Subroutines
        /// <summary>載入教友(會員)資料</summary>
        private void LoadMemberData()
        {
            //載入會員資料
            var Members = AccountExaminer.LoadMember();
            DgvAccountView.Rows.Clear();
            foreach (var M in Members)
            {
                DgvAccountView.Rows.Add(new object[]
                {
                    M.MemberID,
                    M.Name,
                    M.GenderIsMale ? "男" : "女",
                    M.Birthdate?.ToString("yyyy/MM/dd") ?? "",
                    M.PhoneNumber??"",
                    M.Email??"",
                    M.HomeAddress??"",
                    M.IsBaptised ? "是" : "否",
                    M.ModifiedBy,
                    M.ModifiedDate == DateTime.MinValue ? "" : M.ModifiedDate.ToString("yyyy/MM/dd HH:mm:ss")
                });
            }
        }
        #endregion
        /// <summary>「新增」鈕事件</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAccountEditor AE = new(CurrentUser);
            AE.ShowDialog(this);
            LoadMemberData();
        }
    }
}

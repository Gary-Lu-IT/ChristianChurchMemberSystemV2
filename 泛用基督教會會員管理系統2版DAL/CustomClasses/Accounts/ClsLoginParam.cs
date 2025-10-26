namespace 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts
{
    /// <summary>登入系統用封包</summary>
    public class ClsLoginParam
    {
        /// <summary>帳號</summary>
        public string UserID { get; set; } = string.Empty;
        /// <summary>密碼</summary>
        public string Password { get; set; } = string.Empty;
    }
    /// <summary>登入系統傳回結果</summary>
    public class ClsLoginResult
    {
        /// <summary>登入是否成功</summary>
        public bool IsSuccess { get; set; } = false;
        /// <summary>錯誤訊息</summary>
        public string ErrorMessage { get; set; } = string.Empty;
        /// <summary>使用者名稱</summary>
        public string UserName { get; set; } = string.Empty;
        /// <summary>使用者角色</summary>
        public string UserRole { get; set; } = string.Empty;
    }
    /// <summary>變更密碼用封包</summary>
    public class ClsChangePasswordParam
    {
        /// <summary>帳號</summary>
        public string UserID { get; set; } = string.Empty;
        /// <summary>舊密碼</summary>
        public string OldPassword { get; set; } = string.Empty;
        /// <summary>新密碼</summary>
        public string NewPassword { get; set; } = string.Empty;
    }
}

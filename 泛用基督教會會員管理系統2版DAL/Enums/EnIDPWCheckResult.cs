namespace 泛用基督教會會員管理系統2版DAL.Enums
{
    /// <summary>帳號密碼檢核結果</summary>
    public enum EnIDPWCheckResult
    {
        /// <summary>OK</summary>
        OK = 0,
        /// <summary>帳號尚未設定密碼</summary>
        PasswordNotSet = -1,
        /// <summary>ID不存在</summary>
        IDNotFound = -2,
        /// <summary>密碼錯誤</summary>
        PasswordWrong = -3,
        /// <summary>短時間內密碼錯誤次數過多</summary>
        FailedTooManyTimesShortly=-4
    }
}

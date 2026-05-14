namespace 泛用基督教會會員管理系統2版DAL.Enums
{
    /// <summary>重設密碼原因</summary>
    public enum EnResetPasswordReason
    {
        /// <summary>無</summary>
        None = 0,
        /// <summary>忘記密碼</summary>
        ForgotPassword = 1,
        SecurityBreach = 2,
        /// <summary>使用者需求</summary>
        UserRequest = 3,
        /// <summary>管理者重設</summary>
        AdminReset = 4,
        /// <summary>使用者新設定</summary>
        NewUserSetup = 5
    }
}
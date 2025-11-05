using 泛用基督教會會員管理系統2版DAL.CustomClasses.BaseClasses;

namespace 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts
{
    /// <summary>成員資料基底類別</summary>
    public abstract class ClsMemberData
    {
        /// <summary>會員登入帳號</summary>
        public string MemberID { get; set; } = null!;
        /// <summary>姓名</summary>
        public string Name { get; set; } = null!;
        /// <summary>性別是否為男性</summary>
        public bool GenderIsMale { get; set; }  
        /// <summary>出生日</summary>
        public DateTime? Birthdate { get; set; }
        /// <summary>電話號碼(不限定住家還是手機)</summary>
        public string? PhoneNumber { get; set; }
        /// <summary>電子郵件信箱</summary>
        public string? Email { get; set; }
        /// <summary>住家電話</summary>
        public string? HomeAddress { get; set; }
        /// <summary>是否受洗</summary>
        public bool IsBaptised { get; set; }
    }
    /// <summary>資料新增用參數</summary>
    public class ClsCreateMemberParam : ClsMemberData, ClsCreateData
    {
        // 實作 ClsCreateData 介面所需屬性
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
    /// <summary>資料修改用參數</summary>
    public class ClsModifyMemberParam : ClsMemberData, ClsModifyData
    {
        // 實作 ClsModifyData 介面所需屬性
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}

namespace 泛用基督教會會員管理系統2版DAL.CustomClasses.BaseClasses
{
    /// <summary>資料建立基底類別</summary>
    public interface ClsCreateData
    {
        /// <summary>資料建立者ID</summary>
        string CreatedBy { get; set; }
        /// <summary>資料建立時間</summary>
        DateTime CreatedDate { get; set; }
    }
    /// <summary>資料修改基底類別</summary>
    public interface ClsModifyData
    {
        /// <summary>資料修改者ID</summary>
        string ModifiedBy { get; set; }
        /// <summary>資料修改時間</summary>
        DateTime ModifiedDate { get; set; }
    }
}

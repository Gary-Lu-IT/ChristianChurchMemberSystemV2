namespace 泛用基督教會會員管理系統2版DAL.CustomClasses.DIYProperties
{
    /// <summary>自定義(自訂)屬性值</summary>
    public class ClsDIYProperty
    {
        /// <summary>屬性群組名稱</summary>
        public string PropertyGroup { get; set; } = null!;
        /// <summary>屬性值</summary>
        public string PropertyValue { get; set; } = null!;
        /// <summary>屬性名稱</summary>
        public string PropertyName { get; set; } = null!;
        /// <summary>是否具有系統管理員權限(屬性群組='Role'(角色)才適用)</summary>
        public bool AdminPrivilege { get; set; } = false;
    }
}

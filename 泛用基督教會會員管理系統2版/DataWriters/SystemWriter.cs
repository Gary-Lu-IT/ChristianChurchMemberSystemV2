using 泛用基督教會會員管理系統2版DAL.CustomClasses.DIYProperties;
using 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

namespace 泛用基督教會會員管理系統2版通用API.DataWriters
{
    /// <summary>系統運作相關資料寫入器</summary>
    internal class SystemWriter
    {
        /// <summary>批次存入自訂屬性值</summary>
        /// <param name="properties"></param>
        public static void WriteDIYProperty(ClsDIYProperty[] properties)
        {
            ChurchMembersNewContext db = new();
            string[] GroupNames=(from p in properties select p.PropertyGroup).Distinct().ToArray();
            foreach (string GN in GroupNames)
            {
            }
        }
    }
}

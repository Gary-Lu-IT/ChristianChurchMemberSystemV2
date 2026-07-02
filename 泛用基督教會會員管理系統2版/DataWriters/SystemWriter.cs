using 泛用基督教會會員管理系統2版DAL.CustomClasses.DIYProperties;
using 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

namespace 泛用基督教會會員管理系統2版通用API.DataWriters
{
    /// <summary>系統運作相關資料寫入器</summary>
    internal class SystemWriter
    {
        #region 自訂屬性值(DIY Properties)
        /// <summary>
        /// 新增自訂屬性值(DIY Properties)
        /// </summary>
        /// <param name="dIYProperty"></param>
        public static void AddDIYProperty(ClsDIYProperty dIYProperty)
        {
            ChurchMembersNewContext db = new();
            var newProperty = new DIYPROPERTIES
            {
                GROUPS = dIYProperty.PropertyGroup,
                PROPNAME = dIYProperty.PropertyName,
                PROPID = dIYProperty.PropertyValue,
                ADMINPRIVILEGE = (dIYProperty.AdminPrivilege ? 1 : 0)
            };
            db.DIYPROPERTIES.Add(newProperty);
            db.SaveChanges();
        }
        /// <summary>新增自訂屬性值(批次)</summary>
        /// <param name="dIYProperties"></param>
        public static void AddDIYProperty(ClsDIYProperty[] dIYProperties)
        {
            ChurchMembersNewContext db = new();
            var newProperties = dIYProperties.Select(dIYProperty => new DIYPROPERTIES
            {
                GROUPS = dIYProperty.PropertyGroup,
                PROPNAME = dIYProperty.PropertyName,
                PROPID = dIYProperty.PropertyValue,
                ADMINPRIVILEGE = (dIYProperty.AdminPrivilege ? 1 : 0)
            }).ToList();
            db.DIYPROPERTIES.AddRange(newProperties);
            db.SaveChanges();
        }
        /// <summary>編輯既有的自訂屬性值</summary>
        /// <param name="dIYProperty"></param>
        public static void EditDIYProperty(ClsDIYProperty dIYProperty)
        {
            ChurchMembersNewContext db = new();
            var existingProperty = db.DIYPROPERTIES.FirstOrDefault(p => p.GROUPS == dIYProperty.PropertyGroup && p.PROPNAME == dIYProperty.PropertyName);
            if (existingProperty != null)
            {
                existingProperty.PROPID = dIYProperty.PropertyValue;
                existingProperty.ADMINPRIVILEGE = (dIYProperty.AdminPrivilege ? 1 : 0);
                db.SaveChanges();
            }
        }
        /// <summary>刪除自訂屬性值</summary>
        /// <param name="groupName"></param>
        /// <param name="propertyName"></param>
        public static void DeleteDIYProperty(string groupName, string propertyName)
        {
            ChurchMembersNewContext db = new();
            var existingProperty = db.DIYPROPERTIES.FirstOrDefault(p => p.GROUPS == groupName && p.PROPNAME == propertyName);
            if (existingProperty != null)
            {
                db.DIYPROPERTIES.Remove(existingProperty);
                db.SaveChanges();
            }
        }
        /// <summary>依群組(項目)名稱取得屬性名稱與對應值</summary>
        /// <param name="GroupName"></param>
        /// <returns></returns>
        public static ClsDIYProperty[] GetDIYProperties(string GroupName="")
        {
            ChurchMembersNewContext db = new();
            if (string.IsNullOrWhiteSpace(GroupName))
            {
                return (from p in db.DIYPROPERTIES
                        select new ClsDIYProperty
                        {
                            PropertyGroup = p.GROUPS,
                            PropertyName = p.PROPNAME,
                            PropertyValue = p.PROPID
                        }).ToArray();
            }
            else
            {
                return (from p in db.DIYPROPERTIES
                        where p.GROUPS == GroupName
                        select new ClsDIYProperty
                        {
                            PropertyGroup = p.GROUPS,
                            PropertyName = p.PROPNAME,
                            PropertyValue = p.PROPID
                        }).ToArray();
            }
        }
        #endregion
    }
}

using System.Reflection;

namespace 泛用基督教會會員管理系統2版DAL.CustomClasses
{
    /// <summary>自訂訊息屬性</summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class DataTypeAttribute : Attribute
    {
        public string Description { get; }

        public DataTypeAttribute(string description)
        {
            Description = description;
        }
    }

    /// <summary>系統常見訊息</summary>
    [Serializable]
    public enum SystemReturnMessage
    {
        /// <summary>成功</summary>
        [DataType("成功")]
        Success = 1,
        /// <summary>帳號與密碼有錯誤</summary>
        [DataType("帳號與密碼有錯誤")]
        WrongIDOrPassword = 101,
        /// <summary>帳號與密碼不可空白</summary>
        [DataType("帳號與密碼不可空白")]
        EmptyIDOrPassword = 102,
        /// <summary>教友ID不存在</summary>
        [DataType("教友ID不存在")]
        MemberIDNotExist = 121,
        /// <summary>教友資料已停用</summary>
        [DataType("教友資料已停用")]
        MemberDataStopped = 122,
        /// <summary>家庭編號不存在</summary>
        [DataType("家庭編號不存在")]
        FamilyIDNotExist = 141,
        /// <summary>家庭內有教友存在，不可刪除</summary>
        [DataType("家庭內有教友存在，不可刪除")]
        FamilyHasMembers = 142,
        /// <summary>公告ID不存在</summary>
        [DataType("公告ID不存在")]
        AnnouncementIDNotExist = 161,
        /// <summary>活動設定ID不存在</summary>
        [DataType("活動設定ID不存在")]
        EventSettingIDNotExist = 181,
        /// <summary>活動頻率不正確</summary>
        [DataType("活動頻率不正確")]
        FrequencyNotValid = 182,
        /// <summary>活動時間格式不正確，請使用 HH:mm 格式。</summary>
        [DataType("活動時間格式不正確，請使用 HH:mm 格式。")]
        InvalidTimeFormat = 183,
        /// <summary>系統不明錯誤</summary>
        [DataType("系統不明錯誤")]
        SystemError = 10001
    }

    /// <summary>Enum 擴充方法：取得 DataType 屬性的描述文字</summary>
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo? field = value.GetType().GetField(value.ToString());
            if (field != null)
            {
                DataTypeAttribute? attribute =
                    (DataTypeAttribute?)Attribute.GetCustomAttribute(field, typeof(DataTypeAttribute));

                if (attribute != null)
                {
                    return attribute.Description;
                }
            }
            return value.ToString();
        }
    }

    /// <summary>本系統自訂錯誤</summary>
    public class ChurchMemberException : Exception
    {
        public SystemReturnMessage ErrorCode { get; set; }

        /// <summary>錯誤碼</summary>
        public int Code => (int)ErrorCode;

        /// <summary>建構函式</summary>
        public ChurchMemberException(SystemReturnMessage errorCode)
            : base(errorCode.GetDescription())  // 使用擴充方法取得訊息
        {
            ErrorCode = errorCode;
        }
    }
}
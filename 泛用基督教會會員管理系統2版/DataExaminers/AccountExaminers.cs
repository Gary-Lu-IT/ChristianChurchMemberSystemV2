using 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts;
using 泛用基督教會會員管理系統2版DAL.CustomClasses;
using 泛用基督教會會員管理系統2版通用API.DataWriters;

namespace 泛用基督教會會員管理系統2版通用API.DataExaminers
{
    /// <summary>帳號相關資料檢核區</summary>
    public class AccountExaminers
    {
        /// <summary>登入作業</summary>
        /// <param name="Param"></param>
        /// <returns></returns>
        public static ClsLoginResult Login(ClsLoginParam Param)
        {
            if(Param.UserID=="admin" && Param.Password == "admin" + DateTime.Now.ToString("yyyyMMdd"))
            {
                return AccountWriter.Login(Param);
            }
            else
            {
                throw new Exception("此部分功能仍在開發中，敬請期待。");
            }
        }
        /// <summary>建立使用者</summary>
        /// <param name="Param"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void AddMember(ClsCreateMemberParam Param)
        {
            if (string.IsNullOrEmpty(Param.MemberID))
            {
                throw new ChurchMemberException(SystemReturnMessage.RequiredDataIsEmpty, "必填資料未填寫：帳號");
            }
            AccountWriter.AddMember(Param);
        }
        /// <summary>修改會員資料</summary>
        /// <param name="Param"></param>
        /// <exception cref="ChurchMemberException"></exception>
        public static void UpdateMember(ClsModifyMemberParam Param)
        {
            if (string.IsNullOrEmpty(Param.MemberID))
            {
                throw new ChurchMemberException(SystemReturnMessage.RequiredDataIsEmpty, "必填資料未填寫：帳號");
            }
            AccountWriter.UpdateMember(Param);
        }
    }
}

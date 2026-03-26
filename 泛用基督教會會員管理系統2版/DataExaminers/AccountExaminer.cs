using 泛用基督教會會員管理系統2版DAL.CustomClasses;
using 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts;
using 泛用基督教會會員管理系統2版通用API.DataWriters;

namespace 泛用基督教會會員管理系統2版通用API.DataExaminers
{
    /// <summary>帳號相關資料檢核區</summary>
    public class AccountExaminer
    {
        /// <summary>登入作業</summary>
        /// <param name="Param"></param>
        /// <returns></returns>
        public static ClsLoginResult Login(ClsLoginParam Param)
        {
            if (Param.UserID == "admin" && Param.Password == "admin" + DateTime.Now.ToString("yyyyMMdd"))
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
            if (AccountWriter.GetMember(Param.MemberID) != null)
            {
                throw new ChurchMemberException(SystemReturnMessage.MemberIDAlreadyExist, "帳號已存在，請更換其他帳號。");
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
        /// <summary>取得所有會員資料</summary>
        /// <returns></returns>
        public static List<ClsModifyMemberParam> LoadMember()
        {
            return AccountWriter.LoadMember();
        }
        /// <summary>取得指定帳號的會員資料</summary>
        /// <param name="MemberId"></param>
        /// <returns></returns>
        /// <exception cref="ChurchMemberException"></exception>
        public static ClsModifyMemberParam GetMember(string MemberId)
        {
            if (string.IsNullOrEmpty(MemberId))
            {
                throw new ChurchMemberException(SystemReturnMessage.RequiredDataIsEmpty, "必填資料未填寫：帳號");
            }
            return AccountWriter.GetMember(MemberId)!;
        }
        /// <summary>刪除一筆使用者資料</summary>
        /// <param name="LoginID">使用者帳號</param>
        /// <exception cref="ChurchMemberException">找不到欲刪除的使用者資訊</exception>
        public static void DeleteMember(string? LoginID)
        {
            if (string.IsNullOrEmpty(LoginID))
            {
                throw new ChurchMemberException(SystemReturnMessage.RequiredDataIsEmpty, "必填資料未填寫：帳號");
            }
            if(AccountWriter.GetMember(LoginID) == null)
            {
                throw new ChurchMemberException(SystemReturnMessage.MemberIDNotExist, "找不到會員資料，無法進行刪除作業，會員代號：" + LoginID);
            }
            AccountWriter.DeleteMember(LoginID);
        }
    }
}

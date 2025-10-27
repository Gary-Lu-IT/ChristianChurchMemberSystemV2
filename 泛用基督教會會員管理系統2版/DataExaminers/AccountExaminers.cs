using 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts;
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
    }
}

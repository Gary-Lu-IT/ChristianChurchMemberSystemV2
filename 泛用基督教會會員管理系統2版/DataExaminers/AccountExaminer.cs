using 泛用基督教會會員管理系統2版DAL.CustomClasses;
using 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts;
using 泛用基督教會會員管理系統2版DAL.Enums;
using 泛用基督教會會員管理系統2版通用API.DataWriters;
using 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

namespace 泛用基督教會會員管理系統2版通用API.DataExaminers
{
    /// <summary>帳號相關資料檢核區</summary>
    public class AccountExaminer
    {
        /// <summary>固定時間格式</summary>
        private static string DateTimeFormat = "yyyy/MM/dd HH:mm:ss";
        #region 登入登出、密碼
        /// <summary>檢查密碼</summary>
        /// <param name="UserID"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        /// <exception cref="ChurchMemberException"></exception>
        public static EnIDPWCheckResult CheckPassword(string UserID, string Password, out MEMBERPASSWORDS? CheckResult)
        {
            var db = new ChurchMembersNewContext();
            var U=db.MEMBERS.Where(x => x.LOGINID == UserID).FirstOrDefault();
            if (U == null)
            {
                CheckResult = null;
                return EnIDPWCheckResult.IDNotFound;
            }
            ClsSetPasswordParam clsSetPasswordParam = new()
            {
                UserID = UserID,
                Password = Password
            };
            var MP = db.MEMBERPASSWORDS.Where(x => x.LOGINID == UserID).FirstOrDefault();
            CheckResult = MP;
            if (MP == null)
            {
                return EnIDPWCheckResult.PasswordNotSet;
            }
            if (MP.LOGINPWD != clsSetPasswordParam.EncodedPassword)
            {
                return EnIDPWCheckResult.PasswordWrong;
            }
            return EnIDPWCheckResult.OK;
        }
        /// <summary>登入作業</summary>
        /// <param name="Param"></param>
        /// <returns></returns>
        public static ClsLoginResult Login(ClsLoginParam Param)
        {
            if(Param.UserID == "admin")
            {
                if(Param.Password == "admin" + DateTime.Now.ToString("yyyyMMdd"))
                {
                    return AccountWriter.Login(Param);
                }
                else
                {
                    throw new ChurchMemberException(SystemReturnMessage.WrongIDOrPassword);
                }
            }
            else
            {
                var db = new ChurchMembersNewContext();
                MEMBERPASSWORDS? MP;
                EnIDPWCheckResult en = CheckPassword(Param.UserID, Param.Password, out MP);
                switch (en)
                {
                    case EnIDPWCheckResult.OK:
                        return AccountWriter.Login(Param);
                    case EnIDPWCheckResult.PasswordNotSet:
                        throw new ChurchMemberException(SystemReturnMessage.PasswordNotSet, "此帳號尚未設定密碼，請聯絡系統管理員協助設定密碼。");
                    case EnIDPWCheckResult.PasswordWrong:
                        // 依照登入失敗的帳號，記錄登入失敗的時間，並且產生一筆登入失敗紀錄。
                        int sn = GetNextSerialByTable(ref db, "LOGINFAILRECORD");
                        db.LOGINFAILRECORD.Add(new LOGINFAILRECORD
                        {
                            FAILID = IntToHex(sn),
                            LOGINID = Param.UserID,
                            FAILTIME = DateTime.Now.ToString(DateTimeFormat)
                        });
                        db.SaveChanges();
                        // 取得最近30分鐘內的登入失敗紀錄，如果超過3次，則暫停此帳號登入。
                        if (AccountWriter.GetLoginFailRecord(Param.UserID,DateTime.Now.AddMinutes(-30),DateTime.Now).Count >= 3)
                        {
                            throw new ChurchMemberException(SystemReturnMessage.PasswordErrorTooManyTimes, "密碼輸入錯誤次數過多");
                        }
                        throw new ChurchMemberException(SystemReturnMessage.WrongIDOrPassword, "帳號或密碼錯誤，請重新輸入。");
                    case EnIDPWCheckResult.IDNotFound:
                        throw new ChurchMemberException(SystemReturnMessage.WrongIDOrPassword, "帳號或密碼錯誤，請重新輸入。");
                    default:
                        throw new ChurchMemberException(SystemReturnMessage.SystemError, "系統發生未知錯誤，請聯絡系統管理員協助處理。");
                }
                throw new Exception("此部分功能仍在開發中，敬請期待。");
            }
        }
        /// <summary>設定密碼</summary>
        /// <param name="Param"></param>
        public static void SetPassword(ClsSetPasswordParam Param)
        {
            if (Param.UserID == "admin") {
                throw new ArgumentException("admin帳號的密碼由系統自動管理，無法由使用者自行設定。");
            }
            AccountWriter.SetPassword(Param);
        }
        #endregion

        #region MEMBERS(教友(使用者)基本資料表)
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
        #endregion

        #region Subroutines(副程式)
        /// <summary>依表格取用最近一個可以取用的長整數流水號，並累加表示這個長整數流水號已取用。</summary>
        /// <param name="db"></param>
        /// <param name="TableName"></param>
        private static int GetNextSerialByTable(ref ChurchMembersNewContext db, string TableName)
        {
            int ret;
            var Serial = db.SERIAL_TABLE.Where(x => x.TABLENAME == TableName).FirstOrDefault();
            if(Serial == null)
            {
                ret = int.MinValue;
                db.SERIAL_TABLE.Add(new SERIAL_TABLE
                {
                    TABLENAME = TableName,
                    USEDSERIAL = ret
                });
            }
            else
            {
                ret = Serial.USEDSERIAL + 1;
                Serial.USEDSERIAL = ret;
            }
            //db.SaveChanges()這一行就由呼叫此Subroutine的上層Subroutine來執行，搭配上層Subroutine內對資料庫的操作可以形成transaction，最後再一次存檔。
            return ret;
        }
        /// <summary>把32為元整數轉成16進位格式字串後，整理成****-****-****-****的格式，
        /// 對於大於0的數字左端補0。</summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string IntToHex(int value) {
            string hex = value.ToString("X8").PadLeft(16, '0');
            return hex.Substring(0,4)+"-"+ hex.Substring(4, 4) + "-" + hex.Substring(8, 4) + "-" + hex.Substring(12, 4);
        }
        #endregion
    }
}

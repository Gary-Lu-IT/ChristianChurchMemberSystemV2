using 泛用基督教會會員管理系統2版DAL.Accounts;
using 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

namespace 泛用基督教會會員管理系統2版通用API.DataWriters
{
    /// <summary>帳號相關資料寫入器</summary>
    public class AccountWriter
    {
        /// <summary>登入作業</summary>
        /// <param name="Param"></param>
        /// <returns></returns>
        public static ClsLoginResult Login(ClsLoginParam Param)
        {
            ChurchMembersNewContext db = new();
            SERIAL_TABLE? ST = db.SERIAL_TABLE.Where(x => x.TABLENAME == "LOGINRECORD").FirstOrDefault();
            int NewSerial = ST == null ? -2 ^ 63 : (ST.USEDSERIAL + 1);
            if (ST == null)
            {
                db.SERIAL_TABLE.Add(new SERIAL_TABLE
                {
                    TABLENAME = "LOGINRECORD",
                    USEDSERIAL = NewSerial
                });
            }
            else
            {
                ST.USEDSERIAL = NewSerial;
            }
            if (Param.UserID=="admin" && Param.Password == "admin" + DateTime.Now.ToString("yyyyMMdd"))
            {
                // 登入成功(最高權限系統管理員)
                db.LOGINRECORD.Add(new LOGINRECORD
                {
                    SERIAL = FormatSerial(NewSerial),
                    LOGINID = Param.UserID,
                    LOGINTIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                });
                db.SaveChanges();
                return new ClsLoginResult
                {
                    IsSuccess = true,
                    UserName = "系統管理員",
                    UserRole = "SystemAdmin"
                };
            }
            else
            {
                throw new NotImplementedException("此部分功能仍在開發中，敬請期待。");
            }
        }
        /// <summary>流水號轉成16進位數，每四位數中間隔著一個減號，如1234-5678-9ABC-DEF0這樣</summary>
        /// <param name="Serial"></param>
        /// <returns></returns>
        private static string FormatSerial(int Serial)
        {
            string Hex = Serial.ToString("X");
            Hex=Hex.PadLeft(16, '0');
            Hex = Hex.Substring(0, 4) + "-" + Hex.Substring(4, 4) + "-" + Hex.Substring(8, 4) + "-" + Hex.Substring(12, 4);
            return Hex;
        }
    }
}

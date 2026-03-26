using 泛用基督教會會員管理系統2版DAL.CustomClasses;
using 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts;
using 泛用基督教會會員管理系統2版通用API.SQLiteModels.Church;

namespace 泛用基督教會會員管理系統2版通用API.DataWriters
{
    /// <summary>帳號相關資料寫入器</summary>
    internal class AccountWriter
    {
        /// <summary>登入作業</summary>
        /// <param name="Param"></param>
        /// <returns></returns>
        public static ClsLoginResult Login(ClsLoginParam Param)
        {
            ChurchMembersNewContext db = new();
            SERIAL_TABLE? ST = db.SERIAL_TABLE.Where(x => x.TABLENAME == "LOGINRECORD").FirstOrDefault();
            int NewSerial = ST == null ? (-2 ^ 32) : (ST.USEDSERIAL + 1);
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
                    UserID = Param.UserID,
                    IsSuccess = true,
                    UserName = "系統管理員",
                    UserRole = "SystemAdmin",
                    ErrorMessage = string.Empty
                };
            }
            else
            {
                throw new NotImplementedException("此部分功能仍在開發中，敬請期待。");
            }
        }
        /// <summary>建立使用者</summary>
        /// <param name="Param"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void AddMember(ClsCreateMemberParam Param)
        {
            ChurchMembersNewContext db = new();
            db.MEMBERS.Add(new MEMBERS
            {
                LOGINID = Param.MemberID,
                USERNAME = Param.Name,
                BIRTHDATE = Param.Birthdate?.ToString("yyyy-MM-dd"),
                GENDER = Param.GenderIsMale ? 1 : 0,
                PHONE = Param.PhoneNumber,
                EMAIL = Param.Email,
                ADDRESS = Param.HomeAddress,
                BAPTISED = Param.IsBaptised ? 1 : 0,
                CREATOR = Param.CreatedBy,
                CREATEDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MODIFIER = Param.CreatedBy,
                MODIFIEDDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            });
            db.SaveChanges();
        }
        /// <summary>修改會員資料</summary>
        /// <param name="Param"></param>
        /// <exception cref="ChurchMemberException"></exception>
        public static void UpdateMember(ClsModifyMemberParam Param)
        {
            ChurchMembersNewContext db = new();
            MEMBERS? M = db.MEMBERS.Where(x => x.LOGINID == Param.MemberID).FirstOrDefault();
            if (M != null)
            {
                M.USERNAME = Param.Name;
                M.BIRTHDATE = Param.Birthdate?.ToString("yyyy-MM-dd");
                M.GENDER = Param.GenderIsMale ? 1 : 0;
                M.PHONE = Param.PhoneNumber;
                M.EMAIL = Param.Email;
                M.ADDRESS = Param.HomeAddress;
                M.BAPTISED = Param.IsBaptised ? 1 : 0;
                M.MODIFIER = Param.ModifiedBy;
                M.MODIFIEDDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                db.SaveChanges();
            }
            else
            {
                throw new ChurchMemberException(SystemReturnMessage.MemberIDNotExist, $"找不到會員資料，無法進行修改作業，會員代號：{Param.MemberID}");
            }
        }
        /// <summary>取得一筆使用者資料</summary>
        /// <param name="LoginID">使用者帳號</param>
        /// <returns></returns>
        public static ClsModifyMemberParam? GetMember(string LoginID)
        {
            return new ChurchMembersNewContext().MEMBERS.Where(x => x.LOGINID == LoginID)
                .Select(x => new ClsModifyMemberParam
                {
                    MemberID = x.LOGINID,
                    Name = x.USERNAME,
                    Birthdate = string.IsNullOrEmpty(x.BIRTHDATE) ? null : DateTime.Parse(x.BIRTHDATE),
                    GenderIsMale = x.GENDER == 1,
                    PhoneNumber = x.PHONE,
                    Email = x.EMAIL,
                    HomeAddress = x.ADDRESS,
                    IsBaptised = x.BAPTISED == 1,
                    ModifiedBy = x.MODIFIER,
                    ModifiedDate = string.IsNullOrEmpty(x.MODIFIEDDATE) ? DateTime.MinValue : default
                }).FirstOrDefault();
        }
        /// <summary>刪除一筆使用者資料</summary>
        /// <param name="LoginID">使用者帳號</param>
        /// <exception cref="ChurchMemberException">找不到欲刪除的使用者資訊</exception>
        public static void DeleteMember(string LoginID)
        {
            ChurchMembersNewContext db = new();
            MEMBERS? M = db.MEMBERS.Where(x => x.LOGINID == LoginID).FirstOrDefault();
            if (M != null)
            {
                db.MEMBERS.Remove(M);
                db.SaveChanges();
            }
            else
            {
                throw new ChurchMemberException(SystemReturnMessage.MemberIDNotExist, $"找不到會員資料，無法進行刪除作業，會員代號：{LoginID}");
            }
        }
        /// <summary>取得所有會員資料</summary>
        /// <returns></returns>
        public static List<ClsModifyMemberParam> LoadMember()
        {
            return new ChurchMembersNewContext().MEMBERS.Select(x => new ClsModifyMemberParam
            {
                MemberID = x.LOGINID,
                Name = x.USERNAME,
                Birthdate = string.IsNullOrEmpty(x.BIRTHDATE) ? null : DateTime.Parse(x.BIRTHDATE),
                GenderIsMale = x.GENDER == 1,
                PhoneNumber = x.PHONE,
                Email = x.EMAIL,
                HomeAddress = x.ADDRESS,
                IsBaptised = x.BAPTISED == 1,
                ModifiedBy = x.MODIFIER,
                ModifiedDate = string.IsNullOrEmpty(x.MODIFIEDDATE) ? DateTime.MinValue : default
            }).ToList();
        }
        #region 副程式
            /// <summary>流水號轉成16進位數，每四位數中間隔著一個減號，如1234-5678-9ABC-DEF0這樣</summary>
            /// <param name="Serial">整數型態流水號</param>
            /// <param name="Header">前置字串</param>
            /// <returns></returns>
        private static string FormatSerial(int Serial, string Header = "")
        {
            string Hex = Serial.ToString("X");
            Hex=Hex.PadLeft(16, '0');
            Hex = Hex.Substring(0, 4) + "-" + Hex.Substring(4, 4) + "-" + Hex.Substring(8, 4) + "-" + Hex.Substring(12, 4);
            Hex = Header + Hex;
            return Hex;
        }
        /// <summary>SHA512加密</summary>
        /// <param name="OriginPassword"></param>
        /// <returns></returns>
        private static string SHA512Encode(string OriginPassword)
        {
            using (var sha512 = System.Security.Cryptography.SHA512.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(OriginPassword);
                byte[] hash = sha512.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
        #endregion
    }
}

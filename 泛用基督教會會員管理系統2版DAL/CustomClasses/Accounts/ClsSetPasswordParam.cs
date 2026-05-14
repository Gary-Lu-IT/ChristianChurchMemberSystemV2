using System.Security.Cryptography;
using System.Text;

namespace 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts
{
    /// <summary>密碼設定用封包</summary>
    public class ClsSetPasswordParam
    {
        /// <summary>使用者帳號</summary>
        public string UserID { get; set; } = null!;
        /// <summary>使用者密碼</summary>
        public string Password { get; set; } = null!;
        /// <summary>加密後密碼</summary>
        public string EncodedPassword
        {
            get
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(Password);
                byte[] hashBytes = SHA512.HashData(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}

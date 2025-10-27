using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using 泛用基督教會會員管理系統2版DAL.CustomClasses.Accounts;
using 泛用基督教會會員管理系統2版通用API.DataExaminers;

namespace 泛用基督教會會員管理系統2版WEBAPI.Controllers
{
    /// <summary>帳號相關控制器</summary>
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        /// <summary>登入作業</summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public IActionResult Login([FromBody] ClsLoginParam param)
        {
            try
            {
                ClsLoginResult LR = AccountExaminers.Login(param);
                return Ok(LR);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

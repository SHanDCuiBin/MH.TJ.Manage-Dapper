using MH.TJ.Manage.IService.basicinfo;
using MH.TJ.Manage.Utility._ApiResult;
using MH.TJ.Manage.Utility._DESEncrypt;
using MH.TJ.Manage.Utility._MD5;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthoizeController : ControllerBase
    {
        private readonly Idoctor_auth_userService _idoctor_Auth_UserService;
        public AuthoizeController(Idoctor_auth_userService idoctor_Auth_UserService)
        {
            this._idoctor_Auth_UserService = idoctor_Auth_UserService;
        }

        /// <summary>
        /// 登陆  
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="userpwd">密码</param>
        /// <returns></returns>
        [HttpPost("Login")]
        public async Task<ApiResult> Login(string username, string userpwd)
        {
          //  string pwd = DESEncrypt.JiaMiStr(userpwd);
          //  var users = await _idoctor_Auth_UserService.QueryAsync(c => c.user_id == username && c.password == pwd);
          //  if (users != null && users.Count > 0)
          //  {
          //      var user = users[0];
          //
          //      //访问张三
          //      // this.User.Identity.Name;
          //
          //      var claims = new Claim[]
          //                    {
          //                        new Claim(ClaimTypes.Name, user.real_name),
          //                        new Claim("userid", user.user_id),
          //                        new Claim("UserName", user.real_name)
          // 
          //                        //不能存放敏感信息
          //                    };
          //      var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SDMC-CJAS1-SAD-DFSFA-SADHJVF-VF"));
          //      //issuer代表颁发Token的Web应用程序，audience是Token的受理者
          //      var token = new JwtSecurityToken(
          //          issuer: "http://localhost:6060",
          //          audience: "http://localhost:55405",
          //          claims: claims,
          //          notBefore: DateTime.Now,
          //          expires: DateTime.Now.AddHours(1),
          //          signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
          //      );
          //      var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
          //      return ApiResultHelper.Success(jwtToken);
          //  }
          //  else
          //  {
          //      return ApiResultHelper.Error("账号或密码错误");
          //  }

            return ApiResultHelper.Error("账号或密码错误");
        }
    }
}

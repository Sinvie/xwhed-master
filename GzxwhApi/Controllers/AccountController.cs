using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sinvie.M;

namespace Sinvie.M.D.U.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public AccountController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            })
            .ToArray();
        }

        /// <summary>
        /// 用户登录接口
        /// </summary>
        /// <param name="LoginName">登录账号或者手机号码</param>
        /// <param name="LoginPass">注册时填写的密码，若忘记，请使用找回密码</param>
        /// <returns>成功则返回用户信息；失败则返回失败原因</returns>
        [HttpGet("Login")]
        public ActionResult Login(string LoginName,string LoginPass)
        {
            return Ok(new ApiResultModel() { status = "success", log = "您输入的登录名：" + LoginName + "；登录密码：" + LoginPass, data = "" });
        }

        /// <summary>
        /// 用户注册接口
        /// </summary>
        /// <param name="mobile">输入手机号</param>
        /// <param name="pass">设置的登录密码</param>
        /// <param name="code">短信验证码</param>
        /// <returns>成功则返回注册信息；失败则返回失败原因</returns>
        [HttpGet("Signup")]
        public ActionResult Signup(string mobile,string pass,string code)
        {
            return Ok(new ApiResultModel() { status = "success", log = "您输入的登录名：" + mobile + "；登录密码：" + pass, data = "" });
        }
    }
}
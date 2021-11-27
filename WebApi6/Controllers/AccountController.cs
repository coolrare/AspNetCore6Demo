using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi6.Helpers;

namespace WebApi6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly JwtHelpers helper;
        public AccountController(JwtHelpers helper)
        {
            this.helper = helper;

        }
        [HttpPost("~/login")]
        public ActionResult<LoginResult> Login(LoginViewModel model)
        {
            if (model.UserID == "will")
            {
                LoginResult result = new() {
                    AccessToken = helper.GenerateToken(model.UserID)
                };

                return result;
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
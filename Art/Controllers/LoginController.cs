﻿using Art.Pages.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Art.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;

        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        //[AllowAnonymous]
        //[HttpPost]
        //public IActionResult Login([FromBody] UserLogin userLogin)
        //{
        //    var user = Authenticate(userLogin);

        //    if (user != null)
        //    {
        //        var token = Generate(user);
        //        return Ok(token);
        //    }

        //    return NotFound("User not found");
        //}

        //private string Generate(UserModel user)
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        //    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        //    var claims = new[]
        //    {
        //        new Claim(ClaimTypes.NameIdentifier, user.Username),
        //        new Claim(ClaimTypes.Email, user.EmailAddres),
        //        new Claim(ClaimTypes.GivenName, user.GivenName),
        //        new Claim(ClaimTypes.Surname, user.Surname),
        //        new Claim(ClaimTypes.Role, user.Role),
        //    };
        //}

        //private UserModel Authenticate(UserLogin userLogin)
        //{
        //    var currentUser = UserConstans.Users.FirstOrDefault(o => o.Username.ToLower() ==
        //    userLogin.Username.ToLower() && o.Password == userLogin.Password);

        //    if (currentUser != null)
        //    {
        //        return currentUser;
        //    }

        //    return null;
        //}
    }
}
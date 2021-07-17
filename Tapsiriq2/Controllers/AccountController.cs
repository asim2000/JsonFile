using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapsiriq2.Controllers
{
    [Route("[controller]")]
    public class AccountController:Controller
    {
        [HttpGet("login")] // account/login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("login")]
        public IActionResult Login(string username,string password)
        {
            if (username=="admin" && password=="12345")
            {
                HttpContext.Session.SetString("username", username);
                return Redirect("/home/creatUser");
            }
            ModelState.AddModelError("", "Istifadeci adi ve parol yalnisdir");
            return View();
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/account/login");
        }
    }
}

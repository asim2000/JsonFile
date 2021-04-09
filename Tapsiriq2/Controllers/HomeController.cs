using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tapsiriq2.Models;

namespace Tapsiriq2.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult CreatUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatUser(User model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var file = System.IO.File.ReadAllText("User.json");
            List<User> users;
            if (!string.IsNullOrEmpty(file))
            {
                users = JsonConvert.DeserializeObject<List<User>>(file);
                users.Add(model);
            }
            else
            {
                users = new List<User>();
                users.Add(model);
            }

            WriteToJsonFile(users);
            return Redirect("~/home/userList");
        }
        [HttpGet]
        public IActionResult UserList()
        {
            var json=System.IO.File.ReadAllText(@"User.json");
            
            var users = JsonConvert.DeserializeObject<List<User>>(json);
            if (users==null)
            {
                return Redirect("~/home/creatUser");
            }
            return View(users);
        }

        public void WriteToJsonFile(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users);
            System.IO.File.WriteAllText(@"User.json", json);
        }
    }
    
}
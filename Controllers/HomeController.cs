using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoApplication.Models;
using NWMSWebApplication.Models;
using System.Data.SqlClient;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Collections;

namespace DemoApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LoginValidate(Login login)
        {
            ResourceManager rm = new ResourceManager("UserData", Assembly.GetExecutingAssembly());
            if(login.UserName.ToLower()=="ravi" && login.Password=="ravi563" || login.UserName.ToLower() == "swaroop" && login.Password == "swaroop563"|| login.UserName.ToLower() == "shiva" && login.Password == "shiva563")
            {
                login.isrite = true;
                return View();
            }

            return View();
        }

        [HttpGet]
        public ActionResult User()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegisterValidate(Register register)
        {

            return View();
        }
    }
}

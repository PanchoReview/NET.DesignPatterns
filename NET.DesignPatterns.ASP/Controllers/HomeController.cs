using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET.DesignPatterns.ASP.Configuration;
using NET.DesignPatterns.ASP.Models;
using NET.DesignPatterns.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NET.DesignPatterns.ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> config;

        public HomeController(IOptions<MyConfig> config)
        {
            this.config = config;
        }

        public IActionResult Index()
        {
            Log.GetInstance(config.Value.PathLog).Save("Entró a Index");
            return View();
        }

        public IActionResult Privacy()
        {
            Log.GetInstance(config.Value.PathLog).Save("Entró a Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

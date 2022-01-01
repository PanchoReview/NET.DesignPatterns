using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET.DesignPatterns.ASP.Configuration;
using NET.DesignPatterns.ASP.Models;
using NET.DesignPatterns.Model;
using NET.DesignPatterns.Repository;
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
        private readonly IRepository<Beer> repository;

        public HomeController(IOptions<MyConfig> config, IRepository<Beer> repository)
        {
            this.config = config;
            this.repository = repository;
        }

        public IActionResult Index()
        {
            Log.GetInstance(config.Value.PathLog).Save("Entró a Index");

            var lst = repository.Get();
            return View(lst);
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

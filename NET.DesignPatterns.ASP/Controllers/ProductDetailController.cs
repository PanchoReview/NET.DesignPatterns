using Microsoft.AspNetCore.Mvc;
using NET.DesignPatterns.Tools.Earn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET.DesignPatterns.ASP.Controllers
{
    public class ProductDetailController : Controller
    {
        private LocalEarnFactory localEarnFactory;
        private ForeignEarnFactory foreignEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            this.localEarnFactory = localEarnFactory;
            this.foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            // products
            var localEarn = localEarnFactory.GetEarn();
            var foreignEarn = foreignEarnFactory.GetEarn();

            // total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}

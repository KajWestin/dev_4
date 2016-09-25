using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dev_4.Domain.Logic;

namespace dev_4.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var veh = new Vehicle();

            var firstS = veh.GetSpeed();

            veh.IncreaseSpeed(10);

            var secS = veh.GetSpeed();

            veh.IncreaseSpeed(100);

            var thS = veh.GetSpeed();

            veh.DecreaseSpeed(40);

            var lastS = veh.GetSpeed();



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
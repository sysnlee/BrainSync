using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrainSyncSite.Controllers
{
    public class HealthController : Controller
    {
        // GET: Health
        public ActionResult Index()
        {
            ViewBag.Message = "健康是一切開始的前提！";
            return View();
        }
    }
}
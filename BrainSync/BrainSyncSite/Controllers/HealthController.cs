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
        //在这里实现一个基于HTML5的3D浏览工具
        public ActionResult Index()
        {
            ViewBag.Message = "健康是一切開始的前提！";
            return View();
        }
    }
}

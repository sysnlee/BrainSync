using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrainSyncSite.Controllers
{
    public class SupportController : Controller
    {
        // GET: Support
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "点击客服，可以与我们实时通讯。";

            return View();
        }
    }
}
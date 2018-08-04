using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrainSyncSite.Controllers
{
    public class SupportController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Message = "点击客服，可以与我们实时通讯。";
            ViewBag.Head = "提供全方位的技術支持是我們的習慣。";
            return View();
        }
    }
}
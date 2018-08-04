using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrainSyncSite.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            ViewBag.Message = "最近發生的事情";

            return View();
        }
        //这里规划为一个论坛、在线编辑器、页面通讯
        public ActionResult News()
        {
            

            return View();
        }
    }
}
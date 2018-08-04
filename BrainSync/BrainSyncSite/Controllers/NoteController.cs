using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrainSyncSite.Note.Controllers
{
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            ViewBag.Message = "今天的狀態會影響明天的自己。全力以赴！";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiPageRouting.MvcSample.Controllers
{
    public class MobileHomeController : Controller
    {
        // GET: MobileHome
        public ActionResult Index()
        {
            return View();
        }
    }
}
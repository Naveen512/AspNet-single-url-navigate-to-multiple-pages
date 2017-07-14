using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiPageRouting.MvcSample.Controllers
{
    public class DesktopHomeController : Controller
    {
        // GET: DesktopHome
        public ActionResult Index()
        {
            return View();
        }
    }
}
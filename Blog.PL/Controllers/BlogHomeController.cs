using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.PL.Controllers
{
    public class BlogHomeController : Controller
    {
        public ActionResult BlogSiteHome()
        {
            return View();
        }
    }
}
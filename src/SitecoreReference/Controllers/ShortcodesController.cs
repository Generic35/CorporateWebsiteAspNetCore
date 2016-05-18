using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace SitecoreReference.Controllers
{
    public class ShortcodesController : Controller
    {
        // GET: Shortcodes
        public ActionResult Index()
        {
            return View();
        }
    }
}
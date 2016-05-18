using SitecoreReference.Services;
using SitecoreReference.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace SitecoreReference.Controllers
{
    public class HomeController : Controller
    {
        // GET: Corlate
        public ActionResult Index()
        {
            return View();
        }
    }
}
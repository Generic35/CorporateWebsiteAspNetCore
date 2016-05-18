using SitecoreReference.Services;
using SitecoreReference.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace SitecoreReference.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }
    }
}
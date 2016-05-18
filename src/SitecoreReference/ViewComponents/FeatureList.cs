using Microsoft.AspNet.Mvc;
using SitecoreReference.Services;

namespace SitecoreReference.ViewComponents
{
    public class FeatureList : ViewComponent
    {
        IServicesService _servicesService;

        public FeatureList(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        public IViewComponentResult Invoke()
        {
            var services = _servicesService.GetAll();
            return View("Default", services);
        }
    }
}

using Microsoft.AspNet.Mvc;
using SitecoreReference.Services;

namespace SitecoreReference.ViewComponents
{
    public class Locations : ViewComponent
    {
        ILocationService _locationsService;

        public Locations(ILocationService locationService)
        {
            _locationsService = locationService;
        }

        public IViewComponentResult Invoke()
        {
            var locations = _locationsService.GetAll();
            return View("Default", locations);
        }
    }
}

using Microsoft.AspNet.Mvc;
using SitecoreReference.Services;

namespace SitecoreReference.ViewComponents
{
    public class RecentWork : ViewComponent
    {
        IRecentWorkService _recentWorkService;

        public RecentWork(IRecentWorkService recentWorkService)
        {
            _recentWorkService = recentWorkService;
        }

        public IViewComponentResult Invoke()
        {
            var recentWork = _recentWorkService.GetAll();
            return View("Default", recentWork);
        }
    }
}

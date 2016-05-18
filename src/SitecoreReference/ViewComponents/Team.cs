using Microsoft.AspNet.Mvc;
using SitecoreReference.Services;

namespace SitecoreReference.ViewComponents
{
    public class Team : ViewComponent
    {
        ITeamMemberProfileService _teamMemberProfileService;

        public Team(ITeamMemberProfileService teamMemberProfileService)
        {
            _teamMemberProfileService = teamMemberProfileService;
        }

        public IViewComponentResult Invoke()
        {
            var teamMemberProfiles = _teamMemberProfileService.GetAll();
            return View("Default", teamMemberProfiles);
        }
    }
}

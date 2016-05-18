using SitecoreReference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreReference.Dal
{
    public interface IDataSource
    {
        IEnumerable<ClientComment> GetAllClientComments();
        IEnumerable<TeamMemberProfile> GetAllTeamMemberProfiles();
        IEnumerable<Service> GetAllServices();
        IEnumerable<RecentWork> GetAllRecentWork();
        IEnumerable<Location> GetAllLocations();
    }
}

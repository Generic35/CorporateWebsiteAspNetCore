using System;
using System.Collections.Generic;
using System.Linq;
using SitecoreReference.Models;
using SitecoreReference.Dal;

namespace SitecoreReference.Services
{
    public class TeamMemberProfileService : ITeamMemberProfileService
    {
        IDataSource _repo;
        public TeamMemberProfileService(IDataSource repo)
        {
            _repo = repo;
        }

        public IEnumerable<TeamMemberProfile> GetAll()
        {
            return _repo.GetAllTeamMemberProfiles();
        }
    }
}
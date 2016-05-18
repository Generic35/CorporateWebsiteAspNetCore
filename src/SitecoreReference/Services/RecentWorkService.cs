using System;
using System.Collections.Generic;
using System.Linq;
using SitecoreReference.Models;
using SitecoreReference.Dal;

namespace SitecoreReference.Services
{
    public class RecentWorkService : IRecentWorkService
    {
        IDataSource _repo;
        public RecentWorkService(IDataSource repo)
        {
            _repo = repo;
        }

        public IEnumerable<RecentWork> GetAll()
        {
            return _repo.GetAllRecentWork();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using SitecoreReference.Models;
using SitecoreReference.Dal;

namespace SitecoreReference.Services
{
    public class LocationService : ILocationService
    {
        IDataSource _repo;
        public LocationService(IDataSource repo)
        {
            _repo = repo;
        }

        public IEnumerable<Location> GetAll()
        {
            return _repo.GetAllLocations();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using SitecoreReference.Models;
using SitecoreReference.Dal;

namespace SitecoreReference.Services
{
    public class ServicesService : IServicesService
    {
        IDataSource _repo;
        public ServicesService(IDataSource repo)
        {
            _repo = repo;
        }

        public IEnumerable<Service> GetAll()
        {
            return _repo.GetAllServices();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using SitecoreReference.Models;
using SitecoreReference.Dal;

namespace SitecoreReference.Services
{
    public class ClientCommentService : IClientCommentService
    {
        IDataSource _repo;
        public ClientCommentService(IDataSource repo)
        {
            _repo = repo;
        }

        public IEnumerable<ClientComment> GetAll()
        {
            return _repo.GetAllClientComments();
        }
    }
}
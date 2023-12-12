using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ApplicationRepository : IApplicationRepository, IRepository<Application>
    {
        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<Application>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Application>> GetAllApplications()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Application>> GetAllApplicationsById(int ApplicationId)
        {
            throw new NotImplementedException();
        }

        public Task<Application> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Application> Insert(Application Element)
        {
            throw new NotImplementedException();
        }

        public Task<Application> Update(Application Element)
        {
            throw new NotImplementedException();
        }
    }
}

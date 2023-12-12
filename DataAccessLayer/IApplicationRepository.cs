using DataAccessLayer.Entities;

namespace DataAccessLayer
{
    public interface IApplicationRepository : IRepository<Application>
    {
        public Task<IQueryable<Application>> GetAllApplications();
        public Task<IQueryable<Application>> GetAllApplicationsById(int ApplicationId);
    }
}

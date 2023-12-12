namespace DataAccessLayer
{
    public interface IRepository<T> : IDisposable
    {
        public Task<List<T>> GetAll();
        public Task<T> GetById(int Id);
        public Task<T> Insert(T Element);
        public Task<T> Update(T Element);
        public Task Delete(int Id);
    }
}

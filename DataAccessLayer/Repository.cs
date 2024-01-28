using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PonyContext _context;
        private bool disposedValue;

        public Repository(PonyContext context)
        {
            _context = context;
        }

        public async Task Delete(int Id)
        {
            var ItemToDelete = _context.Set<T>().Find(Id);
            if (ItemToDelete != null)
            {
                _context.Set<T>().Remove(ItemToDelete);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }
        }
        public async Task<List<T>> GetAll()
        {
            try
            {
                var Items = await _context.Set<T>().ToListAsync();
                return Items;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка чтения данных: {ex.Message}");
            }
        }
        public async Task<T> GetById(int Id)
        {
            var Item = await _context.Set<T>().FindAsync(Id);

            return Item;
        }

        public async Task<T> Insert(T Element)
        {
            if (Element != null)
            {
                _context.Set<T>().Add(Element);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }

                return Element;
            }
            else
            {
                return null;
            }
        }

        public async Task<T> Update(T Element)
        {
            _context.Set<T>().Update(Element);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Element;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

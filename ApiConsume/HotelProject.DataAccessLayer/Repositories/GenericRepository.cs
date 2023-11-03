using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HotelProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task Delete(T entity, bool tracking = true)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByID(int id, bool tracking = false)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList(bool tracking = false)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query.ToList();
            //return _context.Set<T>().ToList();
        }

        public async Task Insert(T entity, bool tracking = true)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity, bool tracking = true)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}

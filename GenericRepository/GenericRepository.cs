/*using FirstWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebMvc.GenericRepository
{
    public class GenericRepository<T> : InterfaceGeneric<T> where T : class
    {
        private DataDbContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new DataDbContext();
            table = _context.Set<T>();
        }
        public GenericRepository(DataDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T entity)
        {
            table.Add(entity);
        }
        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
*/
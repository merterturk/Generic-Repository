using PersonnelApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class Repository<Tentity> : IRepository<Tentity> where Tentity:class
    {
        protected DbContext _context;
        private DbSet<Tentity> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Tentity>();
        }

        public void Add(Tentity entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<Tentity> entities)
        {
            _dbSet.AddRange(entities);
            
        }

        public IEnumerable<Tentity> GetAll()
        {
            return _dbSet.ToList();
        }

        public Tentity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(int id)
        {
            _dbSet.Remove(GetById(id));
        }

        public void RemoveRange(IEnumerable<Tentity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}

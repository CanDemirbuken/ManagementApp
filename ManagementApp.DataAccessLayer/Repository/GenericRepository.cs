using ManagementApp.DataAccessLayer.Abstract;
using ManagementApp.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Add(T t)
        {
            ManagementDbContext _context = new ManagementDbContext();
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Delete(T t)
        {
            ManagementDbContext _context = new ManagementDbContext();
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            ManagementDbContext _context = new ManagementDbContext();
            return _context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            ManagementDbContext _context = new ManagementDbContext();
            return _context.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            ManagementDbContext _context = new ManagementDbContext();
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}

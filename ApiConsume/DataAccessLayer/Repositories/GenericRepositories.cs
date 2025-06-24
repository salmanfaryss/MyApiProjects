using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepositories<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepositories(Context context)
        {
            _context = context;
        }

        public void Delete(T p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void Update(T p)
        {
           _context.Update(p);
            _context.SaveChanges();
        }
    }
}

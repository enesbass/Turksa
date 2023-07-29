using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Turksa.DataAccessLayer.Abstract;
using Turksa.DataAccessLayer.Context;
using Turksa.Entity.Abstract;

namespace Turksa.DataAccessLayer.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly SqlDbContext context;
        public int Insert(T input)
        {
            context.Set<T>().Add(input);
            return context.SaveChanges();
        }

        public int Update(T input)
        {
            context.Set<T>().Update(input);
            return context.SaveChanges();
        }
        public int Delete(T input)
        {
            context.Set<T>().Remove(input);
            return context.SaveChanges();
        }

        public ICollection<T> GetAll(Expression<Func<T, bool>>? filter = null)
        {
            if (filter == null)
                return context.Set<T>().ToList();
            else
                return context.Set<T>().Where(filter).ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        
    }
}

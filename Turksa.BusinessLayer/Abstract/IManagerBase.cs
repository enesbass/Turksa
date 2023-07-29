using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Turksa.Entity.Abstract;

namespace Turksa.BusinessLayer.Abstract
{
    public interface IManagerBase<T> where T : BaseEntity
    {
        public int Insert(T input);

        public int Update(T input);

        public int Delete(T input);

        public T GetById(int id);



        public ICollection<T> GetAll(Expression<Func<T, bool>>? filter = null);
    }
}

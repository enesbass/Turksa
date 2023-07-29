using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turksa.Entity.Concrete;

namespace Turksa.DataAccessLayer.Abstract
{
    public interface IStokRepository: IBaseRepository<Stok>
    {
        public ICollection<Stok> UrunAgaciniGetir();
    }
}

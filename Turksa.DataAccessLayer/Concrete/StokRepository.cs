using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turksa.DataAccessLayer.Abstract;
using Turksa.Entity.Concrete;

namespace Turksa.DataAccessLayer.Concrete
{
    public class StokRepository : BaseRepository<Stok>, IStokRepository
    {
        public ICollection<Stok> UrunAgaciniGetir()
        {
            throw new NotImplementedException();
        }
    }
}

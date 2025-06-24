using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T p);
        void TUpdate(T p);
        void TDelete(T p);
        List<T> TGetList();
        T TGetById(int id);
    }
}

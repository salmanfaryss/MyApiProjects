using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class HizmetManager : IHizmetService
    {
        private readonly IServiceDal _serviceDal;

        public HizmetManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TDelete(Service p)
        {
            _serviceDal.Delete(p);
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
           return _serviceDal.GetList();
        }

        public void TInsert(Service p)
        {
            _serviceDal.Insert(p);
        }

        public void TUpdate(Service p)
        {
           _serviceDal.Update(p);
        }
    }
}

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
    public class SubscribManager : ISubscribService
    {
        private readonly ISubscribDal _subscribDal;

        public SubscribManager(ISubscribDal subscribDal)
        {
            _subscribDal = subscribDal;
        }

        public void TDelete(Subscrib p)
        {
            _subscribDal.Delete(p);
        }

        public Subscrib TGetById(int id)
        {
            return _subscribDal.GetById(id);
        }

        public List<Subscrib> TGetList()
        {
           return _subscribDal.GetList();
        }

        public void TInsert(Subscrib p)
        {
            _subscribDal.Insert(p);
        }

        public void TUpdate(Subscrib p)
        {
           _subscribDal.Update(p);
        }
    }
}

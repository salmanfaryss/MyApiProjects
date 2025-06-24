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
    public class ContactManager :IContactService
    {
        private readonly IcontactDal _contactDal;

        public ContactManager(IcontactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public int ContactCount()
        {
         return  _contactDal.GetContactCount();
        }

        public void TDelete(Contact p)
        {
            _contactDal.Delete(p);
        }

        public Contact TGetById(int id)
        {
           return _contactDal.GetById(id);
        }

        public List<Contact> TGetList()
        {
           return _contactDal.GetList();
        }

        public void TInsert(Contact p)
        {
           _contactDal.Insert(p);
        }

        public void TUpdate(Contact p)
        {
            _contactDal.Update(p);
        }
    }
}

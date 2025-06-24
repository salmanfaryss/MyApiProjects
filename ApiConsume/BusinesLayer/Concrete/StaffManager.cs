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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _stafDal;

        public StaffManager(IStaffDal stafDal)
        {
            _stafDal = stafDal;
        }

        public void TDelete(Staff p)
        {
            _stafDal.Delete(p);
        }

        public Staff TGetById(int id)
        {
          return _stafDal.GetById(id);
        }

        public List<Staff> TGetList()
        {
           return _stafDal.GetList();
        }

        public int TGetStaffCount()
        {
            return _stafDal.GetStaffCount();
        }

        public void TInsert(Staff p)
        {
            _stafDal.Insert(p);
        }

        public List<Staff> TTake4StaffList()
        {
            return _stafDal.Take4StaffList();
        }

        public void TUpdate(Staff p)
        {
           _stafDal.Update(p);
        }
    }
}

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
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public void TDelete(WorkLocation p)
        {
           _workLocationDal.Delete(p);
        }

        public WorkLocation TGetById(int id)
        {
          return _workLocationDal.GetById(id);
        }

        public List<WorkLocation> TGetList()
        {
            return _workLocationDal.GetList();
        }

        public void TInsert(WorkLocation p)
        {
            _workLocationDal.Insert(p);
        }

        public void TUpdate(WorkLocation p)
        {
            _workLocationDal.Update(p);
        }
    }
}

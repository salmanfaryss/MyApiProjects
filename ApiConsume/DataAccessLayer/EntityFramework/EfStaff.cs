using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfStaff:GenericRepositories<Staff>,IStaffDal
    {
        public EfStaff(Context context):base(context) 
        {
            
        }

        public int GetStaffCount()
        {
            var context = new Context();
            return (context.staffs.Count());
        }

        public List<Staff> Take4StaffList()
        {
            var context = new Context();
            var value = context.staffs.Take(4).ToList();
            return value;
        }
    }
}

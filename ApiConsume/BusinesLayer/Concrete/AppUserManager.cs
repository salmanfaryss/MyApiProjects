using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using HotelProject.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public int TAppUserCount()
        {
            return _appUserDal.AppUserCount();
        }

        public void TDelete(AppUser p)
        {
           _appUserDal.Delete(p);
        }

        public AppUser TGetById(int id)
        {
           return _appUserDal.GetById(id);
        }

        public List<AppUser> TGetList()
        {
           return _appUserDal.GetList();
        }

        public void TInsert(AppUser p)
        {
            _appUserDal.Insert(p);
        }

        public void TUpdate(AppUser p)
        {
            _appUserDal.Update(p);
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
            return _appUserDal.UserListWithLocation();
        }

        public List<AppUser> TUsersListWithWorkLocations()
        {
           return _appUserDal.UsersListWithWorkLocations();
        }
    }
}

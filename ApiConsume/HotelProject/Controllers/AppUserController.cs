using BusinesLayer.Abstract;
using EntityLayer.Concrete;
using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {

        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        [HttpGet]
        public IActionResult GetAppUserList()
        {
            var value = _appUserService.TGetList();
            return Ok(value);
        }
        //[HttpPost]
        //public IActionResult AddAppUser(AppUser appUser)
        //{
        //    _appUserService.TInsert(appUser);
        //    return Ok();
        //}
        //[HttpDelete("{id}")]
        //public IActionResult DeleteAppUser(int id)
        //{
        //    var value = _appUserService.TGetById(id);
        //_appUserService.TDelete(value);
        //    return Ok();

        //}
        //[HttpGet("{id}")]
        //public IActionResult AppUserGetById(int id)
        //{
        //    var value =_appUserService.TGetById(id);
        //    return Ok(value);
        //}
        //[HttpPut]
        //public IActionResult UpdateAppUser(AppUser appUser)
        //{
        //    _appUserService.TUpdate(appUser);
        //    return Ok();
        //}
    }
}

using DataAccessLayer.Concrete;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWorkLocationController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserWorkLocationController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorkViewModels
            {
                Name = y.Name,
                Surname = y.Surname,
                WorkLocationID = y.WorkLocationID,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                City = y.City,
                Gender = y.Gender,
                Country = y.Country,
                ImageUrl = y.ImageUrl,

            }).ToList();
            return Ok(values);
        }
    }
}

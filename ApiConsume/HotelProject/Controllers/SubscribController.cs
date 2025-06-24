using BusinesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribController : ControllerBase
    {
        private readonly ISubscribService _subscribService;

        public SubscribController(ISubscribService subscribService)
        {
            _subscribService = subscribService;
        }

        [HttpGet]
        public IActionResult SubscribList()
        {
            var value = _subscribService.TGetList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSubscrib(Subscrib subscrib)
        {
            _subscribService.TInsert(subscrib);

            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscrib(int id)
        {
            var value = _subscribService.TGetById(id);
            _subscribService.TDelete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscrib(int id)
        {
            var value = _subscribService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSubscrib(Subscrib subscrib)
        {
            _subscribService.TUpdate(subscrib);
            return Ok();
        }
    }
}

using BusinesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult GetContact()
        {
            var value = _contactService.TGetList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());

            _contactService.TInsert(contact);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult ContactGetById(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
            return Ok(_contactService.ContactCount());
        }
    }
}

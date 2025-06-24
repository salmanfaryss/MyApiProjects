using AutoMapper;
using BusinesLayer.Abstract;
using Dto.Dtos.RoomDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetRoom2List()
        {
            var value = _roomService.TGetList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddRoom2(RoomAddDto roomAddDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Room>(roomAddDto);
            value.Wifi = false;
            _roomService.TInsert(value);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateRoom2(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Room>(updateRoomDto);
            _roomService.TUpdate(value);
            return Ok(value);
        }
    }
}

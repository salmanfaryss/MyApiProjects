using AutoMapper;
using EntityLayer.Concrete;
using WebUI.Dtos.AboutDto;
using WebUI.Dtos.AppUserDto;
using WebUI.Dtos.BookingDto;
using WebUI.Dtos.ContactDto;
using WebUI.Dtos.LoginDto;
using WebUI.Dtos.RegisterDto;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.SendMessageDto;
using WebUI.Dtos.ServiceDto;
using WebUI.Dtos.SubscribDto;
using WebUI.Dtos.TestimonialDto;

namespace WebUI.Mapping
{
    public class AutoMapConfig:Profile
    {
        public AutoMapConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<DeleteServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();

            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();

            //Odalar Dto
            CreateMap<ResultRoomDto,Room>().ReverseMap();
            CreateMap<AddRoomDto,Room>().ReverseMap();
            CreateMap<UpdateRoomDto,Room>().ReverseMap();
            CreateMap<DeleteRoomDto,Room>().ReverseMap();

            //Testimonial Dto
            CreateMap<ResultTestimonialDto,Testimonial>().ReverseMap();
            //Subscrib Dto 
            CreateMap<CreateSubcribDto, Subscrib>().ReverseMap();

            CreateMap<CreateBookingDto,Booking>().ReverseMap();
            CreateMap<ResultBookingDto,Booking>().ReverseMap();
            CreateMap<ApprovedRezervationDto,Booking>().ReverseMap();

            CreateMap<CreateContactDto,Contact>().ReverseMap();
            CreateMap<GetMessageByIdDto, Contact>().ReverseMap();
            CreateMap<InboxContactDto,Contact>().ReverseMap();

            CreateMap<ResultMessageCategoryDto,MessageCategory>().ReverseMap();

            CreateMap<ResultSendBoxDto,SendMessage>().ReverseMap();
            CreateMap<NewMessageDto,SendMessage>().ReverseMap();
            CreateMap<GetMessageById,SendMessage>().ReverseMap();

            //AppUser
            CreateMap<ResultAppUserListDto,AppUser>().ReverseMap();
        }
    }
}

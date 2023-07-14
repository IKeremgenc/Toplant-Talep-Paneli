using AutoMapper;
using EgeMeet.EntityLayer.Concrete;
using EgeMeet.WebUI.Dtos.MeetingDto;
using EgeMeet.WebUI.Dtos.RegisterDto;

namespace EgeMeet.WebUI.Mapping
{
	public class AutoMapperConfig:Profile
	{

        public AutoMapperConfig()
        {
            CreateMap<CreatNewUserDto,AppUser>().ReverseMap();
            CreateMap<MeetingDto,Meeting>().ReverseMap();
            CreateMap<UpdateMeeting, Meeting>().ReverseMap();
        }
    }
}

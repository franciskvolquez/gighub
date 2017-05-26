using AutoMapper;
using GigHub.Controllers.Api;
using GigHub.Models;

namespace GigHub.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ApplicationUser, UserDto>());
            Mapper.Initialize(cfg => cfg.CreateMap<Gig, GigDto>());
            Mapper.Initialize(cfg => cfg.CreateMap<Notification, NotificationDto>());
        }
    }
}
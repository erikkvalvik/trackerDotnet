using AutoMapper;
using trackerDotnet.Models.Domain;
using trackerDotnet.Models.DTO.User;
using System.Linq;

namespace trackerDotnet.Models.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserReadDTO>();

            CreateMap<UserCreateDTO, User>();

            CreateMap<UserEditDTO, User>();
        }
    }
}

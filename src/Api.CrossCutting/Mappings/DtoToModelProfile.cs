using AutoMapper;
using domain.Dtos.User;
using domain.Models;

namespace crossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>()
                .ReverseMap();
        }
    }
}

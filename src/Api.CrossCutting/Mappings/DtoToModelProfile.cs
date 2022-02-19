using Api.Domain.Dtos.User;
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

            CreateMap<UserModel, UserDtoCreate>()
          .ReverseMap();

            CreateMap<UserModel, UserDtoUpdate>()
          .ReverseMap();
        }
    }
}

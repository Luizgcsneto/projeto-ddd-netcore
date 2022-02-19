using AutoMapper;
using domain.Dtos.Contact;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossCutting.Mappings.Contact
{
    public class ContactEntityToDtoProfile : Profile
    {
        public ContactEntityToDtoProfile()
        {
            CreateMap<ContactDto, ContactEntity>()
                .ReverseMap();

            CreateMap<ContactDtoCreateResult, ContactEntity>()
                .ReverseMap();

            CreateMap<ContactDtoUpdateResult, ContactEntity>()
                .ReverseMap();
        }
    }
}

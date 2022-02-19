using AutoMapper;
using domain.Dtos.Contact;
using domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossCutting.Mappings.Contact
{
    public class ContactDtoToModelProfile : Profile
    {
        public ContactDtoToModelProfile()
        {
            CreateMap<ContactModel, ContactDto>()
                .ReverseMap();

            CreateMap<ContactModel, ContactDtoCreate>()
                .ReverseMap();

            CreateMap<ContactModel, ContactDtoUpdate>()
                .ReverseMap();

        }
    }
}

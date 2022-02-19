using AutoMapper;
using domain.Entities;
using domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossCutting.Mappings.Contact
{
    public class ContactModelToEntityProfile : Profile
    {
        public ContactModelToEntityProfile()
        {
            CreateMap<ContactEntity, ContactModel>()
                .ReverseMap();
        }
    }
}

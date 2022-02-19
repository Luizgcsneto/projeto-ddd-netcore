using AutoMapper;
using domain.Entities;
using domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace crossCutting.Mappings.Pessoa
{
    public class PessoaModelToEntityProfile : Profile 
    {
        public PessoaModelToEntityProfile()
        {
            CreateMap<PessoaEntity, PessoaModel>()
                .ReverseMap();
        }
    }
}

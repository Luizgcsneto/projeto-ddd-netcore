using AutoMapper;
using domain.Dtos.Pessoa;
using domain.Entities;
using domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossCutting.Mappings.Pessoa
{
    public class PessoaEntityToDtoProfile : Profile
    {
        public PessoaEntityToDtoProfile()
        {
            CreateMap<PessoaDto, PessoaEntity>()
                .ReverseMap();

            CreateMap<PessoaDtoCreateResult, PessoaEntity>()
                .ReverseMap();

            CreateMap<PessoaDtoUpdateResult, PessoaEntity>()
                 .ReverseMap();
        }
    }
}

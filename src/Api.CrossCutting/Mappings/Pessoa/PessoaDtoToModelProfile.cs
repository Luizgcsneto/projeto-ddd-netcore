using AutoMapper;
using domain.Dtos.Pessoa;
using domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossCutting.Mappings.Pessoa
{
    public class PessoaDtoToModelProfile : Profile
    {
        public PessoaDtoToModelProfile()
        {
            CreateMap<PessoaModel, PessoaDto>()
                .ReverseMap();

            CreateMap<PessoaModel, PessoaDtoCreate>()
                .ReverseMap();

            CreateMap<PessoaModel, PessoaDtoUpdate>()
                .ReverseMap();
        }
    }
}

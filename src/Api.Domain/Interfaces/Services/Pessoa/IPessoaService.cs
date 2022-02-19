using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using domain.Dtos.Pessoa;
using domain.Entities;

namespace Api.Domain.Interfaces.Services.Pessoa
{
    public interface IPessoaService
    {
        Task<PessoaDto> Get(Guid id);
        Task<IEnumerable<PessoaDto>> GetAll();
        Task<PessoaDtoCreateResult> Post(PessoaDtoCreate pessoa);
        Task<PessoaDtoUpdateResult> Put(PessoaDtoUpdate pessoa);
        Task<bool> Delete(Guid id);

    }
}

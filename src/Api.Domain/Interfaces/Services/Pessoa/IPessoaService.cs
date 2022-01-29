using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using domain.Entities;

namespace Api.Domain.Interfaces.Services.Pessoa
{
    public interface IPessoaService
    {
        Task<PessoaEntity> Get(Guid id);
        Task<IEnumerable<PessoaEntity>> GetAll();
        Task<PessoaEntity> Post(PessoaEntity pessoa);
        Task<PessoaEntity> Put(PessoaEntity pessoa);
        Task<bool> Delete(Guid id);

    }
}

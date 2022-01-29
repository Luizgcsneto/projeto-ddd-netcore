using Api.Domain.Interfaces.Services.Pessoa;
using Api.Domain.Interfaces.Services.User;
using domain.Entities;
using domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Services
{

    public class PessoaService : IPessoaService
    {

        private IRepository<PessoaEntity> _repository;
        public PessoaService(IRepository<PessoaEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<PessoaEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<PessoaEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<PessoaEntity> Post(PessoaEntity pessoa)
        {
            return await _repository.InsertAsync(pessoa);
        }

        public async Task<PessoaEntity> Put(PessoaEntity pessoa)
        {
            return await _repository.UpdateAsync(pessoa);
        }
    }
}

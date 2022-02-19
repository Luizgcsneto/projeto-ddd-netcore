using AutoMapper;
using domain.Dtos.Contact;
using domain.Entities;
using domain.Interfaces;
using domain.Interfaces.Services.Contact;
using domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Services
{
    public class ContactService : IContactService
    {
        private IRepository<ContactEntity> _repository;
        private readonly IMapper _mapper;
        public ContactService(IRepository<ContactEntity> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ContactDto> Get(Guid id)
        {
            var contact = await _repository.SelectAsync(id);

            return _mapper.Map<ContactDto>(contact);
        }

        public async Task<IEnumerable<ContactDto>> GetAll()
        {
            var listContacts = await _repository.SelectAsync();

            return _mapper.Map<IEnumerable<ContactDto>>(listContacts);
        }

        public async Task<ContactDtoCreateResult> Post(ContactDtoCreate contact)
        {
            var model = _mapper.Map<ContactModel>(contact);
            var entity = _mapper.Map<ContactEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<ContactDtoCreateResult>(result);
        }

        public async Task<ContactDtoUpdateResult> Put(ContactDtoUpdate contact)
        {
            var model = _mapper.Map<ContactModel>(contact);
            var entity = _mapper.Map<ContactEntity>(model);
            var result = _repository.UpdateAsync(entity);
            return _mapper.Map<ContactDtoUpdateResult>(result);
        }
    }
}

using domain.Dtos.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Interfaces.Services.Contact
{
    public interface IContactService
    {
        Task<ContactDto> Get(Guid id);
        Task<IEnumerable<ContactDto>> GetAll();
        Task<ContactDtoCreateResult> Post(ContactDtoCreate contact);
        Task<ContactDtoUpdateResult> Put(ContactDtoUpdate contact);
        Task<bool> Delete(Guid id);

    }
}

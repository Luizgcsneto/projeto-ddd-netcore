using Api.Domain.Entities;

namespace domain.Entities
{
    public class ContactEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}

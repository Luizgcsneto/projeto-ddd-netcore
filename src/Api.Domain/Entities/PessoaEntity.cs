using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities
{
    public class PessoaEntity : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

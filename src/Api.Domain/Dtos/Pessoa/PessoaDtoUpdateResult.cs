using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Dtos.Pessoa
{
    public class PessoaDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}

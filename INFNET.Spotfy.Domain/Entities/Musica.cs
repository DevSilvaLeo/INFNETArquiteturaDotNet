using INFNET.Spotfy.Domain.Types;
using INFNET.Spotfy.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.Entities
{
    public class Musica
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public EstiloTypes Estilo { get; set; }
        public Duracao Duracao { get; set; }
    }
}

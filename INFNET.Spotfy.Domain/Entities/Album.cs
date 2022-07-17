using INFNET.Spotfy.Domain.Types;
using INFNET.Spotfy.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.Entities
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Capa { get; set; }
        public EstiloTypes GeneroMusical { get; set; }
        public Banda Banda { get; set; }
        public IList<Musica> Musicas { get; set; }
    }
}

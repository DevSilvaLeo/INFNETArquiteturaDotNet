using INFNET.Spotfy.Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.Entities
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public EstiloTypes Estilo { get; set; }
        public Usuario Usuario { get; set; }
        public IList<Musica> Musicas { get; set; }
    }
}

using INFNET.Spotfy.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Foto { get; set; }
        public CPF CPF { get; set; }
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public IList<Playlist> Playlists { get; set; }
    }
}

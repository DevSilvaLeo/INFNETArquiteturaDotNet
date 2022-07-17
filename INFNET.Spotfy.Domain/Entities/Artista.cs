using INFNET.Spotfy.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.Entities
{
    public class Artista
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Gravadora { get; set; }
        public IList<Album> Albuns { get; set; }
    }
}

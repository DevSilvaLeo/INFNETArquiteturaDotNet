using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.ValueObjects
{
    public class Banda
    {
        public Banda()
        {

        }
        public Banda(String nome)
        {
            this.Nome = nome;
        }

        public String Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}

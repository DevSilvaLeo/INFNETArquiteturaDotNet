using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.ValueObjects
{
    public class Senha
    {
        public Senha()
        {

        }
        public Senha(string value)
        {
            this.Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Value { get; set; }
    }
}

using INFNET.Spotfy.Domain.Entities;
using INFNET.Spotfy.Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.ValueObjects
{
    public class MidiaSocial
    {
        public MidiaSocialTypes Midia { get; set; }
        public string Perfil { get; set; }
    }
}

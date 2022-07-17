using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.ValueObjects
{
    public class Duracao
    {
        public Duracao(decimal valor)
        {
            this.Value = valor;
        }

        public Decimal Value { get; set; }

        public string FormatValue => Formato(this.Value);

        private string Formato(decimal value)
        {
            var hours = Math.Floor(value / 3600);
            var duration = value % 3600;

            var minutes = Math.Floor(duration / 60);
            var seconds = duration % 60;

            if (hours > 0)
            {
                return $"{hours.ToString().PadLeft(2, '0')} Hrs {minutes.ToString().PadLeft(2, '0')} Min  {seconds.ToString().PadLeft(2, '0')} Seg";
            }

            return $"{minutes.ToString().PadLeft(2, '0')} Min  {seconds.ToString().PadLeft(2, '0')} Seg";
        }
    }
}

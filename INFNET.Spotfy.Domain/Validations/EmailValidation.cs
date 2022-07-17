using FluentValidation;
using INFNET.Spotfy.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.Validations
{
    public class EmailValidation : AbstractValidator<Email>
    {
        private const string Pattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        private bool BeAEmailValid(string valor) => Regex.IsMatch(valor, Pattern);
        public EmailValidation()
        {
            RuleFor(x => x.Value)
                .NotEmpty()
                .WithMessage("O Email é obrigatório")
                .Must(BeAEmailValid)
                .WithMessage("Digite um Email válido");
        }
    }
}

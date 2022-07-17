using FluentValidation;
using INFNET.Spotfy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.Validations
{
    public class UsuarioValidation : AbstractValidator<Usuario>
    {
        public UsuarioValidation()
        {
            RuleFor(x=>x.Nome).NotEmpty().WithMessage("O nome é obrigatório");
            RuleFor(x => x.DataNascimento).NotEmpty().WithMessage("A data de nascimento é obrigatória");
            RuleFor(x => x.Senha).NotEmpty().WithMessage("Informe uma senha");
            RuleFor(x => x.CPF).SetValidator(new CpfValidation());
            RuleFor(x=>x.Email).SetValidator(new EmailValidation());
        }
    }
}

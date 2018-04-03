using BuscaIntimacao.Commons;
using BuscaIntimacao.Domain.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaIntimacao.Domain.Validations.Cartorio
{
    public abstract class CartorioCommandValidation<T> : AbstractValidator<T> where T : CartorioCommand
    {
        protected void ValidarNome()
        {
            RuleFor(c => c.Nome)
                   .NotEmpty().WithMessage(string.Format(MessagesValidators.NullOrEmpty, "Nome"))
                   .NotNull().WithMessage(string.Format(MessagesValidators.NullOrEmpty, "Nome"))
                   .Length(5, 50).WithMessage(string.Format(MessagesValidators.Length, "Nome", 5, 255));
        }
    }
}

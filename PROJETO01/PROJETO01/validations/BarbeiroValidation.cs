using FluentValidation;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.validations
{
    public class BarbeiroValidation:AbstractValidator<Barbeiro>
    {

            public BarbeiroValidation()
            {
                RuleFor(barbeiro => barbeiro.Nome)
                    .NotEmpty().WithMessage("Nome é obrigatorio")
                    .NotNull().WithMessage("Nome é obrigatorio")
                    .MinimumLength(3).WithMessage("Informe no mínimo 3 letras no nome")
                    .MaximumLength(255).WithMessage("Informe no máximo 200 letras no nome");

                RuleFor(barbeiro => barbeiro.cpf)
                    .NotNull().WithMessage("Cpf é obrigatório")
                    .NotEmpty().WithMessage("Cpf é obrigatório")
                    .Must(validaCpf).WithMessage("Cpf inválido")
                    .Length(11).WithMessage("Cpf tamanho deve ser de 11 digitos");


                RuleFor(barbeiro => barbeiro.PrecoCorte)
                    .NotNull().WithMessage("preço é obrigatório")
                    .NotEmpty().WithMessage("preço é obrigatório");


                RuleFor(barbeiro => barbeiro.Telefone)
                    .NotNull().WithMessage("Telefone é obrigatório")
                    .NotEmpty().WithMessage("Telefone é obrigatório");

            }


            private static bool validaCpf(string cpf)
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;
                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);

            }

        }
    
}

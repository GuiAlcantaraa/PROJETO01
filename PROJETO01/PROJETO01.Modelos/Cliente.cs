using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public int IdCidade { get; set; }

        public Cidade cidade { get; set; }

    }
}

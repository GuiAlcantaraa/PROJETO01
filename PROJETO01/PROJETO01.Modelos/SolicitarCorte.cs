using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
    public class SolicitarCorte
    {

        public int IdSolicitacao { get; set; }
        public int IdBarbeiro { get; set; }
        public int IdCliente { get; set; }
        public int IdCidade { get; set; }
        public float PrecoCorte { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }

        public Cidade cidade { get; set; }

        public Barbeiro barbeiro { get; set; }

        public Cliente cliente { get; set; }
    }
}

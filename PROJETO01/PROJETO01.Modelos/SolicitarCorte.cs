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

        public Barbeiro barbeiro { get; set; }

        public Cliente cliente { get; set; }
    }
}

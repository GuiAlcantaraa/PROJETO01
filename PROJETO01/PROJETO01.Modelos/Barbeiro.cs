using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO01.Modelos
{
    public class Barbeiro
    {
        public int IdBarbeiro { get; set; }

        public string Nome { get; set; }

        public string cpf { get; set; }

        public float PrecoCorte { get; set; }

        public string Telefone { get; set; }

        public int IdEspecialidade { get; set; }

        public EspecialidadeB Especialidade { get; set; }

    }
}

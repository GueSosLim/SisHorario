using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    class Ciclo
    {
        public int CodigoCiclo { get; private set; }
        public string NombreCiclo { get; private set;}

        private Ciclo()
        {

        }

        public static Ciclo Registrar(int ai_cod_ciclo, string as_nomb_ciclo)
        {
            return new Ciclo()
            {
                CodigoCiclo = ai_cod_ciclo,
                NombreCiclo = as_nomb_ciclo
            };
        }
    }
}

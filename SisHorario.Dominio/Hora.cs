using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    class Hora
    {
        public int id_hora { get; private set; }
        public string desc_hora { get; private set; }

        private Hora()
        {

        }

        public static Hora ObtenerHora()
        {
            return new Hora()
            {

            };
        }
    }
}

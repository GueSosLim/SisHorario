using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    public class Hora
    {
        public int CodigoHora { get; private set; }
        public string DescripcionHora { get; private set; }

        private Hora()
        {

        }
    }
}

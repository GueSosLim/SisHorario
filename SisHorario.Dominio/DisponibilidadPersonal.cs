using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    class DisponibilidadPersonal
    {
        public int CodigoDisponibilidadPersonal { get; private set; }
        public string Dia { get; private set; }
        public int CodigoPersonal { get; private set; }
        public virtual Personal CodPersonal { get; private set; }
        public int CodigoHora { get; private set; }
        public virtual Hora CodHora { get; private set; }
        public int CodigoSemestre { get; private set; }
        public virtual Semestre CodSemestre { get; private set; }

        private DisponibilidadPersonal()
        {

        }
    }
}

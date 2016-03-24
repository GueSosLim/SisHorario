using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    class Horario
    {
        public int CodigoHorario { get; private set; }
        public int CantidadAlumnos { get; private set; }
        public string Seccion { get; private set; }
        public string DiaHorario { get; private set; }
        public string Horas { get; private set; }
        public int CodigoPersonal { get; private set; }
        public virtual Personal CodPersonal { get; private set; }
        public int CodigoCiclo { get; private set; }
        public virtual Ciclo CodCiclo { get; private set; }
        public int CodigoSemestre { get; private set; }
        public virtual Semestre CodSemestre { get; private set; }
        public int CodigoAmbiente { get; private set; }
        public virtual Ambiente CodAmbiente { get; private set; }
        public int CodigoCurso { get; private set; }
        public virtual Curso CodCurso { get; private set; }

        private Horario()
        {

        }
    }
}

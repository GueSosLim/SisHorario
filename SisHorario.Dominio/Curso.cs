using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    class Curso
    {
        public int CodigoCurso { get; private set; }
        public string CodigoDelCurso { get; private set; }
        public string NombreCurso { get; private set; }
        public string HoraTeoria { get; private set; }
        public string HoraPractica { get; private set; }
        public string TotalHoras { get; private set; }
        public string CreditoCurso { get; private set; }
        public string PreRequisitoCurso { get; private set; }
        public string TipoCurso { get; private set; }
        public DateTime FechaCreacion { get; private set; }
        public string ColorCurso { get; private set; }
        public int CodigoPlanEstudio { get; private set; }
        public virtual PlanEstudio CodPlanEstudio { get; private set; }
        public int CodigoCiclo { get; private set; }
        public virtual Ciclo CodCiclo { get; private set; }

        private Curso()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    public class Semestre
    {
        public int CodigoSemestre { get; private set; }
        public string NombreSemestre { get; private set;}
        public string AnioSemestre { get; private set;}
        public string EstadoSemestre { get; private set;}
        public int CodigoPlanEstudio { get; private set; }
        public virtual PlanEstudio CodPlanEstudio { get; private set; }
        private Semestre()
        {

        }

        public static Semestre Registrar(int ai_cod_semestre, string as_nom_semestre, 
            string as_anio_semestre, string as_est_semestre, )
        {
            return new Semestre()
            {

            };
        }
    }
}

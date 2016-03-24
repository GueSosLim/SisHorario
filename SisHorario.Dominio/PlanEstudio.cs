using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    public class PlanEstudio
    {
        public int CodigoPlanEstudio { get; private set; }
        public string NombrePlanEstudio { get; private set; }
        public string DescripcionPlanEstudio { get; private set; }
        public string EstadoPlanEstudio { get; private set; }
        public DateTime FechaCreacionPlanEstudio { get; private set; }



        public static PlanEstudio Registrar(int ai_cod_planestudio, string as_nomb_planestudio, string as_desc_planestudio, string as_est_planestudio)
        {
            return new PlanEstudio()
            {
                CodigoPlanEstudio = ai_cod_planestudio,
                NombrePlanEstudio = as_nomb_planestudio,
                DescripcionPlanEstudio = as_desc_planestudio,
                EstadoPlanEstudio = as_est_planestudio,
                FechaCreacionPlanEstudio = DateTime.Now
            };
        }
    }
}

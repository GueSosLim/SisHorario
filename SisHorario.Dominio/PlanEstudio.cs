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

        public PlanEstudio()
        {

        }

        public static PlanEstudio Registrar(int ri_cod_planestudio, string rs_nomb_planestudio, string rs_desc_planestudio, string rs_est_planestudio)
        {
            return new PlanEstudio()
            {
                CodigoPlanEstudio = ri_cod_planestudio,
                NombrePlanEstudio = rs_nomb_planestudio,
                DescripcionPlanEstudio = rs_desc_planestudio,
                EstadoPlanEstudio = rs_est_planestudio,
                FechaCreacionPlanEstudio = DateTime.Now
            };
        }
        public static PlanEstudio Actualizar(int ai_cod_planestudio, string as_nomb_planestudio, string as_desc_planestudio)
        {
            return new PlanEstudio()
            {
                CodigoPlanEstudio = ai_cod_planestudio,
                NombrePlanEstudio = as_nomb_planestudio,
                DescripcionPlanEstudio = as_desc_planestudio,
                EstadoPlanEstudio = "ACTIVO",
                FechaCreacionPlanEstudio = DateTime.Now
            };
        }
        public static PlanEstudio Desactivar(int di_cod_planestudio)
        {
            return new PlanEstudio()
            {
                CodigoPlanEstudio = di_cod_planestudio,
                EstadoPlanEstudio = "INACTIVO"
            };
        }
        public static PlanEstudio ObtenerPlan(int oi_cod_planestudio, string os_est_planestudio)
        {
            return new PlanEstudio()
            {
                CodigoPlanEstudio = oi_cod_planestudio,
                EstadoPlanEstudio = os_est_planestudio
            };
        }
    }
}

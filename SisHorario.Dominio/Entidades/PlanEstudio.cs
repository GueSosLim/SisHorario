using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    /// <summary>
    /// Clase de dominio Plan de Estudio
    /// </summary>
    public class PlanEstudio
    {
        /// <summary>
        /// Código de Plan de Estudio
        /// </summary>
        public int CodigoPlanEstudio { get; private set; }
        /// <summary>
        /// Nombre del Plan de Estudios
        /// </summary>
        public string NombrePlanEstudio { get; private set; }
        /// <summary>
        /// Descripción del plan de estudios
        /// </summary>
        public string DescripcionPlanEstudio { get; private set; }
        /// <summary>
        /// Estado del Plan de estudio
        /// </summary>
        public string EstadoPlanEstudio { get; private set; }
        /// <summary>
        /// Fecha de creacion del plan de estudio (registro)
        /// </summary>
        public DateTime FechaCreacionPlanEstudio { get; private set; }
        /// <summary>
        /// Constructor de la Clase PlanEstudio
        /// </summary>
        public PlanEstudio()
        {

        }

        /// <summary>
        /// Método que crea una nueva instancia de la clase PlanEstudio
        /// </summary>
        /// <param name="ri_cod_planestudio"></param>
        /// <param name="rs_nomb_planestudio"></param>
        /// <param name="rs_desc_planestudio"></param>
        /// <param name="rs_est_planestudio"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Actualizar Plan de Estudios
        /// </summary>
        /// <param name="ai_cod_planestudio"></param>
        /// <param name="as_nomb_planestudio"></param>
        /// <param name="as_desc_planestudio"></param>
        public void Actualizar(int ai_cod_planestudio, string as_nomb_planestudio, string as_desc_planestudio)
        {
            CodigoPlanEstudio = ai_cod_planestudio;
            NombrePlanEstudio = as_nomb_planestudio;
            DescripcionPlanEstudio = as_desc_planestudio;
            EstadoPlanEstudio = "ACTIVO";
            FechaCreacionPlanEstudio = DateTime.Now;
        }
        /// <summary>
        /// Desactivar Plan de Estudio, no se eliminar para no perder congruencia en los datos
        /// </summary>
        /// <param name="di_cod_planestudio"></param>
        public void Desactivar(int di_cod_planestudio)
        {
            CodigoPlanEstudio = di_cod_planestudio;
            EstadoPlanEstudio = "INACTIVO";
        }
    }
}

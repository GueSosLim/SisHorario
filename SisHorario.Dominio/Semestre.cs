using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    /// <summary>
    /// Clase de Dominio Semestre
    /// </summary>
    public class Semestre
    {
        /// <summary>
        /// Código de Semestre asignado
        /// </summary>
        public int CodigoSemestre { get; private set; }
        /// <summary>
        /// Nombre del Semestre
        /// </summary>
        public string NombreSemestre { get; private set;}
        /// <summary>
        /// Año del Semestre
        /// </summary>
        public string AnioSemestre { get; private set;}
        /// <summary>
        /// Estado actual del Semestre
        /// </summary>
        public string EstadoSemestre { get; private set;}
        /// <summary>
        /// Codigo del Plan de Estudio
        /// </summary>
        public int CodigoPlanEstudio { get; private set; }
        /// <summary>
        /// Código del Plan de Estudio
        /// </summary>
        public virtual PlanEstudio CodPlanEstudio { get; private set; }
        /// <summary>
        /// Constructor de la clase Semestre
        /// </summary>
        private Semestre()
        {

        }
        /// <summary>
        /// Método que crea una nueva instancia de la clase Carga personal
        /// </summary>
        /// <param name="ai_cod_semestre">Código de carga personal</param>
        /// <param name="as_nom_semestre">Sección a la que será asignado el personal</param>
        /// <param name="as_anio_semestre">Código del Personal</param>
        /// <param name="ao_planestudio">Código del Semestre</param>
        /// <param name="as_est_semestre">Estado del Semestre</param>
        /// <returns></returns>
        public static Semestre Registrar(int ai_cod_semestre, string as_nom_semestre, string as_anio_semestre, PlanEstudio ao_planestudio, string as_est_semestre)
        {
            return new Semestre()
            {
                CodigoSemestre = ai_cod_semestre,
                NombreSemestre = as_nom_semestre,
                AnioSemestre = as_anio_semestre,
                EstadoSemestre = as_est_semestre,
                CodPlanEstudio = ao_planestudio,
                CodigoPlanEstudio = ao_planestudio.CodigoPlanEstudio
            };
        }
         
        public void Actualizar(int ai_cod_semestre, string as_nom_semestre, string as_anio_semestre, PlanEstudio ao_planestudio, string as_est_semestre)
        {
            CodigoSemestre = ai_cod_semestre;
            NombreSemestre = as_nom_semestre;
            AnioSemestre = as_anio_semestre;
            EstadoSemestre = as_est_semestre;
            CodPlanEstudio = ao_planestudio;
            CodigoPlanEstudio = ao_planestudio.CodigoPlanEstudio;
        }
        public static Semestre Desactivar()
        {
            return new Semestre()
            {
                EstadoSemestre = "INACTIVO"
            };
        }
    }
}

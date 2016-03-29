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

        public static Semestre Registrar(int ai_cod_semestre, string as_nom_semestre, string as_anio_semestre, PlanEstudio ao_planestudio)
        {
            return new Semestre()
            {
                CodigoSemestre = ai_cod_semestre,
                NombreSemestre = as_nom_semestre,
                AnioSemestre = as_anio_semestre,
                EstadoSemestre = "ACTIVO",
                CodPlanEstudio = ao_planestudio,
                CodigoPlanEstudio = ao_planestudio.CodigoPlanEstudio
            };
        }

        public static Semestre Actualizar(int ai_cod_semestre, string as_nom_semestre, string as_anio_semestre, PlanEstudio ao_planestudio)
        {
            return new Semestre()
            {
                CodigoSemestre = ai_cod_semestre,
                NombreSemestre = as_nom_semestre,
                AnioSemestre = as_anio_semestre,
                EstadoSemestre = "ACTIVO",
                CodPlanEstudio = ao_planestudio,
                CodigoPlanEstudio = ao_planestudio.CodigoPlanEstudio
            };
        }
        public static Semestre Desactivar()
        {
            return new Semestre()
            {
                EstadoSemestre = "INACTIVO"
            };
        }
        public static Semestre ObtenerSemestre(int ai_cod_semestre)
        {
            return new Semestre()
            {
                CodigoSemestre = ai_cod_semestre
            };
        }
        public static Semestre ObtenerSemestreActivo(int ai_cod_semestre, string as_est_semestre)
        {
            return new Semestre()
            {
                CodigoSemestre = ai_cod_semestre,
                EstadoSemestre = as_est_semestre
            };
        }
    }
}

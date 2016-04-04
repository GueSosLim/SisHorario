using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    /// <summary>
    /// Clase de dominio Cuso
    /// </summary>
    public class Curso
    {
        /// <summary>
        /// Código del Curso
        /// </summary>
        public int CodigoCurso { get; private set; }
        /// <summary>
        /// Código asignado al curso
        /// </summary>
        public string CodigoDelCurso { get; private set; }
        /// <summary>
        /// Nombre del Curso
        /// </summary>
        public string NombreCurso { get; private set; }
        /// <summary>
        /// Horas de teoría asignadas al curso
        /// </summary>
        public int HoraTeoria { get; private set; }
        /// <summary>
        /// Horas de práctica asignadas al curso
        /// </summary>
        public int HoraPractica { get; private set; }
        /// <summary>
        /// Total de Horas asignadas al curso
        /// </summary>
        public int TotalHoras { get; private set; }
        /// <summary>
        /// Créditos asignados al curso
        /// </summary>
        public int CreditoCurso { get; private set; }
        /// <summary>
        /// Pre requisitos para llevar el curso
        /// </summary>
        public string PreRequisitoCurso { get; private set; }
        /// <summary>
        /// Tipo de curso (Obligatorio, Electivo)
        /// </summary>
        public string TipoCurso { get; private set; }
        /// <summary>
        /// Fecha de creación del curso
        /// </summary>
        public DateTime FechaCreacion { get; private set; }
        /// <summary>
        /// Color asignado al curso
        /// </summary>
        public string ColorCurso { get; private set; }
        /// <summary>
        /// Código Plan de Estudio
        /// </summary>
        public int CodigoPlanEstudio { get; private set; }
        public virtual PlanEstudio CodPlanEstudio { get; private set; }
        /// <summary>
        /// Código de Ciclo
        /// </summary>
        public int CodigoCiclo { get; private set; }
        public virtual Ciclo CodCiclo { get; private set; }
        /// <summary>
        /// Constructor de la clase Curso
        /// </summary>
        public Curso()
        {
            
        }
        /// <summary>
        /// Método que crea una nueva instancia de la clase Curso
        /// </summary>
        /// <param name="ri_cod_curso">Código del Curso</param>
        /// <param name="rs_cod_d_curso">Código asignado al curso</param>
        /// <param name="rs_nom_curso">Nombre del Curso</param>
        /// <param name="ri_hora_teoria_curso">Horas teoría</param>
        /// <param name="ri_hora_prac_curso">Horas práctica</param>
        /// <param name="ri_tothor_curso">Total horas</param>
        /// <param name="ri_cred_curso">Creditos del curso</param>
        /// <param name="rs_prereq_curso">Pre requisitos del curso</param>
        /// <param name="rs_tipo_curso">Tipo de curso</param>
        /// <param name="rs_color_curso">Color del curso</param>
        /// <param name="ro_planestudio">Código Plan de Estudio</param>
        /// <param name="ro_ciclo">Código del Ciclo</param>
        /// <returns></returns>
        public static Curso Registrar(int ri_cod_curso, string rs_cod_d_curso, string rs_nom_curso, 
            int ri_hora_teoria_curso, int ri_hora_prac_curso, int ri_tothor_curso, int ri_cred_curso, string rs_prereq_curso, 
            string rs_tipo_curso, string rs_color_curso, PlanEstudio ro_planestudio, Ciclo ro_ciclo)
        {
            return new Curso()
            {
                CodigoCurso = ri_cod_curso,
                CodigoDelCurso = rs_cod_d_curso,
                NombreCurso = rs_nom_curso,
                HoraTeoria = ri_hora_teoria_curso,
                HoraPractica = ri_hora_prac_curso,
                TotalHoras =  ri_tothor_curso,
                CreditoCurso = ri_cred_curso,
                PreRequisitoCurso = rs_prereq_curso,
                TipoCurso = rs_tipo_curso,
                FechaCreacion = DateTime.Now,
                ColorCurso = rs_color_curso,
                CodPlanEstudio = ro_planestudio,
                CodigoPlanEstudio = ro_planestudio.CodigoPlanEstudio,
                CodCiclo = ro_ciclo,
                CodigoCiclo = ro_ciclo.CodigoCiclo  
            };
        }

        public static Curso Actualizar(int ai_cod_curso, string as_cod_d_curso, string as_nom_curso,
            int ai_hora_teoria_curso, int ai_hora_prac_curso, int ai_tothor_curso, int ai_cred_curso, string as_prereq_curso,
            string as_tipo_curso, DateTime adt_feccre_curso, string as_color_curso, PlanEstudio ao_planestudio, Ciclo ao_ciclo)
        {
            return new Curso()
            {
                CodigoCurso = ai_cod_curso,
                CodigoDelCurso = as_cod_d_curso,
                NombreCurso = as_nom_curso,
                HoraTeoria = ai_hora_teoria_curso,
                HoraPractica = ai_hora_prac_curso,
                TotalHoras = ai_tothor_curso,
                CreditoCurso = ai_cred_curso,
                PreRequisitoCurso = as_prereq_curso,
                TipoCurso = as_tipo_curso,
                FechaCreacion = adt_feccre_curso,
                ColorCurso = as_color_curso,
                CodPlanEstudio = ao_planestudio,
                CodigoPlanEstudio = ao_planestudio.CodigoPlanEstudio,
                CodCiclo = ao_ciclo,
                CodigoCiclo = ao_ciclo.CodigoCiclo
            };
        }


    }
}

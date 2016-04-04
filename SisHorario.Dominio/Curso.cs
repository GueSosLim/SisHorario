using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    public class Curso
    {
        public int CodigoCurso { get; private set; }
        public string CodigoDelCurso { get; private set; }
        public string NombreCurso { get; private set; }
        public int HoraTeoria { get; private set; }
        public int HoraPractica { get; private set; }
        public int TotalHoras { get; private set; }
        public int CreditoCurso { get; private set; }
        public string PreRequisitoCurso { get; private set; }
        public string TipoCurso { get; private set; }
        public DateTime FechaCreacion { get; private set; }
        public string ColorCurso { get; private set; }
        public int CodigoPlanEstudio { get; private set; }
        public virtual PlanEstudio CodPlanEstudio { get; private set; }
        public int CodigoCiclo { get; private set; }
        public virtual Ciclo CodCiclo { get; private set; }

        public Curso()
        {
            
        }

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

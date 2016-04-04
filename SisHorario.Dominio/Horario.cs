using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    public class Horario
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

        public static Horario Registrar(int ri_cod_horario, int ri_cant_alumnos, string rs_seccion, string rs_diahorario, string rs_horas, 
            Personal ro_personal, Ciclo ro_ciclo, Semestre ro_semestre, Ambiente ro_ambiente, Curso ro_curso)
        {
            return new Horario()
            {
                CodigoHorario = ri_cod_horario,
                CantidadAlumnos = ri_cant_alumnos,
                Seccion = rs_seccion,
                DiaHorario = rs_diahorario,
                Horas = rs_horas,
                CodPersonal = ro_personal,
                CodigoPersonal = ro_personal.CodigoPersonal,
                CodCiclo = ro_ciclo,
                CodigoCiclo = ro_ciclo.CodigoCiclo,
                CodSemestre = ro_semestre,
                CodigoSemestre = ro_semestre.CodigoSemestre,
                CodAmbiente = ro_ambiente,
                CodigoAmbiente = ro_ambiente.CodigoAmbiente,
                CodCurso = ro_curso,
                CodigoCurso = ro_curso.CodigoCurso
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    /// <summary>
    /// Clase de dominio Horario
    /// </summary>
    public class Horario
    {
        /// <summary>
        /// Código de Horario, llave primaria
        /// </summary>
        public int CodigoHorario { get; private set; }
        /// <summary>
        /// Cantidad de Alumnos en este Horario
        /// </summary>
        public int CantidadAlumnos { get; private set; }
        /// <summary>
        /// Seccion de la clase
        /// </summary>
        public string Seccion { get; private set; }
        /// <summary>
        /// Dia de la semana que se ejecuta el horario
        /// </summary>
        public string DiaHorario { get; private set; }
        /// <summary>
        /// Horas
        /// </summary>
        public string Horas { get; private set; }
        /// <summary>
        /// Código del Personal, docente
        /// </summary>
        public int CodigoPersonal { get; private set; }
        /// <summary>
        /// Código del Personal, docente
        /// </summary>
        public virtual Personal CodPersonal { get; private set; }
        /// <summary>
        /// Código del Ciclo
        /// </summary>
        public int CodigoCiclo { get; private set; }
        /// <summary>
        /// Código del Ciclo
        /// </summary>
        public virtual Ciclo CodCiclo { get; private set; }
        /// <summary>
        /// Código del Semestre
        /// </summary>
        public int CodigoSemestre { get; private set; }
        /// <summary>
        /// Código del Semestre
        /// </summary>
        public virtual Semestre CodSemestre { get; private set; }
        /// <summary>
        /// Código del ambiente donde se dicta el curso
        /// </summary>
        public int CodigoAmbiente { get; private set; }
        /// <summary>
        /// Código del ambiente donde se dicta el curso
        /// </summary>
        public virtual Ambiente CodAmbiente { get; private set; }
        /// <summary>
        /// Código del curso dictado
        /// </summary>
        public int CodigoCurso { get; private set; }
        /// <summary>
        /// Código del curso dictado
        /// </summary>
        public virtual Curso CodCurso { get; private set; }
        /// <summary>
        /// Constructor de la clase Horario
        /// </summary>
        private Horario()
        {

        }
        /// <summary>
        /// Metodo que crea una instancia del objeto Horario, se registra un horario nuevo
        /// </summary>
        /// <param name="ri_cod_horario"></param>
        /// <param name="ri_cant_alumnos"></param>
        /// <param name="rs_seccion"></param>
        /// <param name="rs_diahorario"></param>
        /// <param name="rs_horas"></param>
        /// <param name="ro_personal"></param>
        /// <param name="ro_ciclo"></param>
        /// <param name="ro_semestre"></param>
        /// <param name="ro_ambiente"></param>
        /// <param name="ro_curso"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo para actualizar los datos de la instancia del objeto Horario
        /// </summary>
        /// <param name="ri_cod_horario"></param>
        /// <param name="ri_cant_alumnos"></param>
        /// <param name="rs_seccion"></param>
        /// <param name="rs_diahorario"></param>
        /// <param name="rs_horas"></param>
        /// <param name="ro_personal"></param>
        /// <param name="ro_ciclo"></param>
        /// <param name="ro_semestre"></param>
        /// <param name="ro_ambiente"></param>
        /// <param name="ro_curso"></param>
        public void Actualizar(int ri_cod_horario, int ri_cant_alumnos, string rs_seccion, string rs_diahorario, string rs_horas,
            Personal ro_personal, Ciclo ro_ciclo, Semestre ro_semestre, Ambiente ro_ambiente, Curso ro_curso)
        {
            CodigoHorario = ri_cod_horario;
            CantidadAlumnos = ri_cant_alumnos;
            Seccion = rs_seccion;
            DiaHorario = rs_diahorario;
            Horas = rs_horas;
            CodPersonal = ro_personal;
            CodigoPersonal = ro_personal.CodigoPersonal;
            CodCiclo = ro_ciclo;
            CodigoCiclo = ro_ciclo.CodigoCiclo;
            CodSemestre = ro_semestre;
            CodigoSemestre = ro_semestre.CodigoSemestre;
            CodAmbiente = ro_ambiente;
            CodigoAmbiente = ro_ambiente.CodigoAmbiente;
            CodCurso = ro_curso;
            CodigoCurso = ro_curso.CodigoCurso;
        }
    }
}

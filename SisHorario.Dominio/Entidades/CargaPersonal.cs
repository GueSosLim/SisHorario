using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    /// <summary>
    /// Clase de Dominio Carga Personal
    /// </summary>
    public class CargaPersonal
    {
        /// <summary>
        /// Código de Carga Personal
        /// </summary>
        public int CodigoCargaPersonal { get; private set; }
        /// <summary>
        /// Sección a la que será asignado el personal
        /// </summary>
        public string Seccion { get; private set; }
        /// <summary>
        /// Código del Personal
        /// </summary>
        public int CodigoPersonal { get; private set; }

        public virtual Personal CodPersonal { get; private set; }
        /// <summary>
        /// Código del Semestre
        /// </summary>
        public int CodigoSemestre { get; private set; }
        public virtual Semestre CodSemestre { get; private set; }
        /// <summary>
        /// Código del Ciclo
        /// </summary>
        public int CodigoCiclo { get; private set; }
        public virtual Ciclo CodCiclo { get; private set; }
        /// <summary>
        /// Código del Curso
        /// </summary>
        public int CodigoCurso { get; private set; }
        public virtual Curso CodCurso { get; private set; }
        /// <summary>
        /// Constructor de la Clase Carga Personal
        /// </summary>
        private CargaPersonal()
        {

        }
        /// <summary>
        /// Método que crea una nueva instancia de la clase Carga personal
        /// </summary>
        /// <param name="ri_cod_car_personal">Código de carga personal</param>
        /// <param name="rs_seccion">Sección a la que será asignado el personal</param>
        /// <param name="cod_personal">Código del Personal</param>
        /// <param name="cod_semestre">Código del Semestre</param>
        /// <param name="cod_ciclo">Código del Ciclo</param>
        /// <param name="cod_curso">Código del Curso</param>
        /// <returns></returns>
        public static CargaPersonal Registrar(int ri_cod_car_personal, string rs_seccion, Personal cod_personal, Semestre cod_semestre, Ciclo cod_ciclo, Curso cod_curso )
        {
            return new CargaPersonal
            {
                CodigoCargaPersonal = ri_cod_car_personal,
                Seccion = rs_seccion,
                CodigoPersonal = cod_personal.CodigoPersonal,
                CodPersonal = cod_personal,
                CodigoSemestre = cod_semestre.CodigoSemestre,
                CodSemestre = cod_semestre,
                CodigoCiclo = cod_ciclo.CodigoCiclo,
                CodCiclo = cod_ciclo,
                CodigoCurso = cod_curso.CodigoCurso,
                CodCurso = cod_curso                   
            };
        }


        /// <summary>
        /// Actualizar los datos de Carga Personal
        /// </summary>
        /// <param name="ai_cod_car_personal">Codigo de Carga de Personal</param>
        /// <param name="as_seccion">Seccion a la que será asignado el Personal</param>
        /// <param name="cod_personal">Código de Personal</param>
        /// <param name="cod_semestre">Código de Semestre</param>
        /// <param name="cod_ciclo">Código de Ciclo</param>
        /// <param name="cod_curso">Código de Curso</param>
        public void Actualizar(int ai_cod_car_personal, string as_seccion, Personal cod_personal, Semestre cod_semestre, Ciclo cod_ciclo, Curso cod_curso)
        {
            CodigoCargaPersonal = ai_cod_car_personal;
            Seccion = as_seccion;
            CodigoPersonal = cod_personal.CodigoPersonal;
            CodPersonal = cod_personal;
            CodigoSemestre = cod_semestre.CodigoSemestre;
            CodSemestre = cod_semestre;
            CodigoCiclo = cod_ciclo.CodigoCiclo;
            CodCiclo = cod_ciclo;
            CodigoCurso = cod_curso.CodigoCurso;
            CodCurso = cod_curso;
        }
    }
}

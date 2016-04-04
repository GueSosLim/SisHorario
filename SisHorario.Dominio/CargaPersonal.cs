using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    public class CargaPersonal
    {
        public int CodigoCargaPersonal { get; private set; }
        public string seccion { get; private set; }
        public int CodigoPersonal { get; private set; }
        public virtual Personal CodPersonal { get; private set; }
        public int CodigoSemestre { get; private set; }
        public virtual Semestre CodSemestre { get; private set; }
        public int CodigoCiclo { get; private set; }
        public virtual Ciclo CodCiclo { get; private set; }
        public int CodigoCurso { get; private set; }
        public virtual Curso CodCurso { get; private set; }

        private CargaPersonal()
        {

        }

        public static CargaPersonal Registrar(int ai_cod_car_personal, string as_seccion, Personal cod_personal, Semestre cod_semestre, Ciclo cod_ciclo, Curso cod_curso )
        {
            return new CargaPersonal
            {
                CodigoCargaPersonal = ai_cod_car_personal,
                seccion = as_seccion,
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

        public static CargaPersonal Actualizar() {
            return null;
        }

        public static CargaPersonal Eliminar()
        {
            return null;
        }

        public static CargaPersonal ObtenerCargaPersonal()
        {
            return null;
        }
        public static CargaPersonal ObtenerCargaPersonalCurso()
        {
            return null;
        }
    }
}

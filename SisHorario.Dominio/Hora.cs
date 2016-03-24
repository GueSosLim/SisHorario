using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    class Hora
    {
        public int CodigoHora { get; private set; }
        public DateTime InicioHora { get; private set; }
        public DateTime FinHora { get; private set; }
        public int CodigoSemestre { get; private set; }
        public virtual Semestre CodSemestre { get; private set; }

        private Hora()
        {

        }

        public static Hora Registrar(int ai_cod_hora, DateTime adt_ini_hora, DateTime adt_fin_hora, Semestre ao_semestre)
        {
            return new Hora()
            {
                CodigoHora = ai_cod_hora,
                InicioHora = adt_ini_hora,
                FinHora = adt_fin_hora,
                CodSemestre = ao_semestre,
                CodigoSemestre = ao_semestre.CodigoSemestre
                
            };
        }
    }
}

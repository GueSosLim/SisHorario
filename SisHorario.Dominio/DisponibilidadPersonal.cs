using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    public class DisponibilidadPersonal
    {
        public int CodigoDisponibilidadPersonal { get; private set; }
        public string Dia { get; private set; }
        public int CodigoPersonal { get; private set; }
        public virtual Personal CodPersonal { get; private set; }
        public int CodigoHora { get; private set; }
        public virtual Hora CodHora { get; private set; }
        public int CodigoSemestre { get; private set; }
        public virtual Semestre CodSemestre { get; private set; }

        private DisponibilidadPersonal()
        {

        }

        public static DisponibilidadPersonal Registrar(int ai_cod_disp_personal, string as_dia, Personal cod_personal, Hora cod_hora, 
            Semestre cod_semestre)
        {
            return new DisponibilidadPersonal()
            {
                CodigoDisponibilidadPersonal = ai_cod_disp_personal,
                Dia = as_dia,
                CodigoPersonal = cod_personal.CodigoPersonal,
                CodPersonal = cod_personal,
                CodigoHora = cod_hora.CodigoHora,
                CodHora = cod_hora,
                CodigoSemestre = cod_semestre.CodigoSemestre,
                CodSemestre = cod_semestre
            };
        }
    }
}

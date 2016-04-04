using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    /// <summary>
    /// Clase de dominio Disponibilidad Personal
    /// </summary>
    public class DisponibilidadPersonal
    {
        /// <summary>
        /// Código Disponibilidad Personal
        /// </summary>
        public int CodigoDisponibilidadPersonal { get; private set; }
        /// <summary>
        /// Día disponible del personal
        /// </summary>
        public string Dia { get; private set; }
        /// <summary>
        /// Código del Personal
        /// </summary>
        public int CodigoPersonal { get; private set; }
        public virtual Personal CodPersonal { get; private set; }
        /// <summary>
        /// Código de Hora
        /// </summary>
        public int CodigoHora { get; private set; }
        public virtual Hora CodHora { get; private set; }
        /// <summary>
        /// Código del Semestre
        /// </summary>
        public int CodigoSemestre { get; private set; }
        public virtual Semestre CodSemestre { get; private set; }
        /// <summary>
        /// Constructor de la clase Disponibilidad Personal
        /// </summary>
        private DisponibilidadPersonal()
        {

        }
        /// <summary>
        /// Método que crea una nueva instanci de la clase Disponibilidad Personal
        /// </summary>
        /// <param name="ri_cod_disp_personal">Código disponibilidad personal</param>
        /// <param name="rs_dia">Día disponible del personal</param>
        /// <param name="cod_personal">Código del Personal</param>
        /// <param name="cod_hora">Código de Hora</param>
        /// <param name="cod_semestre">Código de Semestre</param>
        /// <returns></returns>
        public static DisponibilidadPersonal Registrar(int ri_cod_disp_personal, string rs_dia, Personal cod_personal, Hora cod_hora, 
            Semestre cod_semestre)
        {
            return new DisponibilidadPersonal()
            {
                CodigoDisponibilidadPersonal = ri_cod_disp_personal,
                Dia = rs_dia,
                CodigoPersonal = cod_personal.CodigoPersonal,
                CodPersonal = cod_personal,
                CodigoHora = cod_hora.CodigoHora,
                CodHora = cod_hora,
                CodigoSemestre = cod_semestre.CodigoSemestre,
                CodSemestre = cod_semestre
            };
        }

        public static DisponibilidadPersonal Actualizar(int ai_cod_disp_personal, string as_dia, Personal cod_personal, Hora cod_hora,
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

        public static DisponibilidadPersonal Eliminar(int ei_cod_disp_personal)
        {
            return new DisponibilidadPersonal()
            {
                CodigoDisponibilidadPersonal = ei_cod_disp_personal
            };
        }
    }
}

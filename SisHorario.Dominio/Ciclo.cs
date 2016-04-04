using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    /// <summary>
    /// Clase de Dominio Ciclo
    /// </summary>
    public class Ciclo
    {
        /// <summary>
        /// Código del Ciclo
        /// </summary>
        public int CodigoCiclo { get; private set; }
        /// <summary>
        /// Nombre del ciclo
        /// </summary>
        public string NombreCiclo { get; private set;}
        /// <summary>
        /// Constructor de la clase Ciclo
        /// </summary>
        private Ciclo()
        {

        }
        /// <summary>
        /// Método que crea una nueva instancia de la clase Ciclo
        /// </summary>
        /// <param name="ai_cod_ciclo">Código del Ciclo</param>
        /// <param name="as_nomb_ciclo">Nombre del Ciclo</param>
        /// <returns></returns>
        public static Ciclo Registrar(int ai_cod_ciclo, string as_nomb_ciclo)
        {
            return new Ciclo()
            {
                CodigoCiclo = ai_cod_ciclo,
                NombreCiclo = as_nomb_ciclo
            };
        }

        public void Actualizar(int ai_cod_ciclo, string as_nomb_ciclo)
        {
            CodigoCiclo = ai_cod_ciclo;
            NombreCiclo = as_nomb_ciclo;
        }

        //public static Ciclo ObtenerCiclo(int ai_cod_ciclo)
        //{
        //    return new Ciclo()
        //    {
        //        CodigoCiclo = ai_cod_ciclo
        //    };
        //}

        //public static Ciclo ObtenerCicloId(string as_nomb_ciclo)
        //{
        //    return new Ciclo()
        //    {
        //        NombreCiclo = as_nomb_ciclo
        //    };
        //}
    }
}

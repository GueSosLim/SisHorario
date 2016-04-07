using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    /// <summary>
    /// Clase Dominio Ambiente
    /// </summary>
    public class Ambiente
    {
        /// <summary>
        /// Código del Ambiente
        /// </summary>
        public int CodigoAmbiente { get; private set; }
        /// <summary>
        /// Nombre del Ambiente según sea el tipo
        /// </summary>
        public string NombreAmbiente { get; private set; }
        /// <summary>
        /// Tipo de Ambiente (Aula, Laboratorio)
        /// </summary>
        public string TipoAmbiente { get; private set; }
        /// <summary>
        /// Capacidad de Ambiente
        /// </summary>
        public int CapacidadAmbiente { get; private set; }
        /// <summary>
        /// Constructor de la clase Ambiente
        /// </summary>
        private Ambiente()
        {

        }

        /// <summary>
        /// Método que crea una nueva instancia de la clase Ambiente
        /// </summary>
        /// <param name="ri_cod_ambiente">Codigo de Ambiente</param>
        /// <param name="rs_nomb_ambiente">Nombre de Ambiente</param>
        /// <param name="rs_tipo_ambiente">Tipo de Ambiente</param>
        /// <param name="ri_cap_ambiente">Capacidad del Ambiente</param>
        /// <returns></returns>

        public static Ambiente Registrar(int ri_cod_ambiente, string rs_nomb_ambiente, string rs_tipo_ambiente, int ri_cap_ambiente)
        {
            return new Ambiente()
            {
                CodigoAmbiente = ri_cod_ambiente,
                NombreAmbiente = rs_nomb_ambiente,
                TipoAmbiente = rs_tipo_ambiente,
                CapacidadAmbiente = ri_cap_ambiente
            };
        }

        /// <summary>
        /// Actualizar datos del Ambiente
        /// </summary>
        /// <param name="ai_cod_ambiente">Código del Ambiente</param>
        /// <param name="as_nomb_ambiente">Nombre del Ambiente</param>
        /// <param name="as_tipo_ambiente">Tipo del Ambiente</param>
        /// <param name="ai_cap_ambiente">Capacidad del Ambiente</param>
        public void Actualizar(int ai_cod_ambiente, string as_nomb_ambiente, string as_tipo_ambiente, int ai_cap_ambiente)
        {
            CodigoAmbiente = ai_cod_ambiente;
            NombreAmbiente = as_nomb_ambiente;
            TipoAmbiente = as_tipo_ambiente;
            CapacidadAmbiente = ai_cap_ambiente;
        }
    }
}

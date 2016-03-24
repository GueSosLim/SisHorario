using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    class Ambiente
    {
        public int CodigoAmbiente { get; private set; }
        public string NombreAmbiente { get; private set; }
        public string TipoAmbiente { get; private set; }
        public int CapacidadAmbiente { get; private set; }
        public string EstadoAmbiente { get; private set; }

        private Ambiente()
        {

        }

        public static Ambiente Registrar(int ai_cod_ambiente, string as_nomb_ambiente, string as_tipo_ambiente, int ai_cap_ambiente, string as_est_ambiente)
        {
            return new Ambiente()
            {
                CodigoAmbiente = ai_cod_ambiente,
                NombreAmbiente = as_nomb_ambiente,
                TipoAmbiente = as_tipo_ambiente,
                CapacidadAmbiente = ai_cap_ambiente,
                EstadoAmbiente = as_est_ambiente
            };
        }
    }
}

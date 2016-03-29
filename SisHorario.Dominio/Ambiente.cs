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

        private Ambiente()
        {

        }

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
        public static Ambiente Actualizar(int ri_cod_ambiente, string rs_nomb_ambiente, string rs_tipo_ambiente, int ri_cap_ambiente)
        {
            return new Ambiente()
            {
                CodigoAmbiente = ri_cod_ambiente,
                NombreAmbiente = rs_nomb_ambiente,
                TipoAmbiente = rs_tipo_ambiente,
                CapacidadAmbiente = ri_cap_ambiente
            };
        }

        public static Ambiente ObtenerAmbiente(int oai_cod_ambiente, string oas_nomb_ambiente, string oas_tipo_ambiente, int oai_cap_ambiente)
        {
            return new Ambiente()
            {
                CodigoAmbiente = oai_cod_ambiente,
                NombreAmbiente = oas_nomb_ambiente,
                TipoAmbiente = oas_tipo_ambiente,
                CapacidadAmbiente = oai_cap_ambiente
            };
        }

        public static Ambiente ObtenerAmbienteCapac(int oaci_cod_ambiente, string oacs_nomb_ambiente, string oacs_tipo_ambiente, int oaci_cap_ambiente)
        {
            return new Ambiente()
            {
                CodigoAmbiente = oaci_cod_ambiente,
                NombreAmbiente = oacs_nomb_ambiente,
                TipoAmbiente = oacs_tipo_ambiente,
                CapacidadAmbiente = oaci_cap_ambiente
            };
        }
        public static Ambiente ObtenerAmbienteID(int oaii_cod_ambiente, string oais_nomb_ambiente, string oais_tipo_ambiente, int oaii_cap_ambiente)
        {
            return new Ambiente()
            {
                CodigoAmbiente = oaii_cod_ambiente,
                NombreAmbiente = oais_nomb_ambiente,
                TipoAmbiente = oais_tipo_ambiente,
                CapacidadAmbiente = oaii_cap_ambiente
            };
        }
    }
}

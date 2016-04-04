using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Dominio
{
    /// <summary>
    /// Clase de dominio Personal
    /// </summary>
    public class Personal
    {
        public int CodigoPersonal { get; private set; }
        public string NombresPersonal { get; private set; }
        public string ApellidosPersonal { get; private set;}
        public string CargoPersonal { get; private set; }
        public string EmailPersonal { get; private set; }
        public string DireccionPersonal { get; private set; }
        public string TelefonoPersonal { get; private set; }
        public string CelularPersonal { get; private set; }
        public string FotoPersonal { get; private set; }
        public string EstadoPersonal { get; private set; }
        public string TipoPersonal { get; private set; }
        public string CategoriaPersonal { get; private set; }

        private Personal()
        {

        }

        public static Personal Registrar(int ai_cod_personal, string as_nom_personal, string as_ape_personal, string as_car_personal, string as_ema_personal, string as_dir_personal, string as_tel_personal, string as_cel_personal, string as_foto_personal, string as_est_personal, string as_tip_personal, string as_cat_personal)
        {
            return new Personal()
            {
                CodigoPersonal = ai_cod_personal,
                NombresPersonal = as_nom_personal,
                ApellidosPersonal = as_ape_personal,
                CargoPersonal = as_car_personal,
                EmailPersonal = as_ema_personal,
                DireccionPersonal = as_dir_personal,
                TelefonoPersonal = as_tel_personal,
                CelularPersonal = as_cel_personal,
                FotoPersonal = as_foto_personal,
                EstadoPersonal = as_est_personal,
                TipoPersonal = as_tip_personal,
                CategoriaPersonal = as_cat_personal
            };
        }

        public static Personal Actualizar()
        {
            return null;
        }

        public static Personal Desactivar()
        {
            return null;
        }
        public static Personal ObtenerPersonal()
        {
            return null;
        }
        public static Personal ObtenerPersonalDocente()
        {
            return null;
        }
        public static Personal ObtenerPersonalID()
        {
            return null;
        }

    }
}

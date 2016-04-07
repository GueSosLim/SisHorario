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
        /// <summary>
        /// Codigo del Personal asignado
        /// </summary>
        public int CodigoPersonal { get; private set; }
        /// <summary>
        /// Nombre del Personal
        /// </summary>
        public string NombresPersonal { get; private set; }
        /// <summary>
        /// Apellidos del Personal
        /// </summary>
        public string ApellidosPersonal { get; private set;}
        /// <summary>
        /// Horario asignado al Personal 
        /// </summary>
        public string CargoPersonal { get; private set; }
        /// <summary>
        /// E-mails que pueda poseer el Personal 
        /// </summary>
        public string EmailPersonal { get; private set; }
        /// <summary>
        /// Direcciones del Personal
        /// </summary>
        public string DireccionPersonal { get; private set; }
        /// <summary>
        /// Teléfonos del Personal
        /// </summary>
        public string TelefonoPersonal { get; private set; }
        /// <summary>
        /// Celulares del Personal
        /// </summary>
        public string CelularPersonal { get; private set; }
        /// <summary>
        /// Foto de Perfil del Personal
        /// </summary>
        public string FotoPersonal { get; private set; }
        /// <summary>
        /// Estado del Personal - Activado, Desactivado
        /// </summary>
        public string EstadoPersonal { get; private set; }
        /// <summary>
        /// Cargo que posee el Personal (Nombrado, Contratado)
        /// </summary>
        public string TipoPersonal { get; private set; }
        /// <summary>
        /// Categoría del Personal
        /// </summary>
        public string CategoriaPersonal { get; private set; }
        
        /// <summary>
        /// Constructor de Clase declarado privado - Solo se pueden llamar a los métodos.
        /// </summary>
        private Personal()
        {

        }

        /// <summary>
        /// Registra un nuevo personal
        /// </summary>
        /// <param name="ri_cod_personal">Código del Personal</param>
        /// <param name="rs_nom_personal">Nombre del Personal</param>
        /// <param name="rs_ape_personal">Apellido del Personal</param>
        /// <param name="rs_car_personal">Cargo del Personal</param>
        /// <param name="rs_ema_personal">E-mails del Personal</param>
        /// <param name="rs_dir_personal">Direcciones del Personal</param>
        /// <param name="rs_tel_personal">Teléfonos del Personal</param>
        /// <param name="rs_cel_personal">Celulares del Personal</param>
        /// <param name="rs_foto_personal">Foto de Perfil del Personal</param>
        /// <param name="rs_est_personal">Estado del Personal</param>
        /// <param name="rs_tip_personal">Tipo del Personal</param>
        /// <param name="rs_cat_personal">Categoría del Personal</param>
        /// <returns></returns>
        public static Personal Registrar(int ri_cod_personal, string rs_nom_personal, string rs_ape_personal, string rs_car_personal, string rs_ema_personal,
            string rs_dir_personal, string rs_tel_personal, string rs_cel_personal, string rs_foto_personal, string rs_est_personal, string rs_tip_personal,
            string rs_cat_personal)
        {
            return new Personal()
            {
                CodigoPersonal = ri_cod_personal,
                NombresPersonal = rs_nom_personal,
                ApellidosPersonal = rs_ape_personal,
                CargoPersonal = rs_car_personal,
                EmailPersonal = rs_ema_personal,
                DireccionPersonal = rs_dir_personal,
                TelefonoPersonal = rs_tel_personal,
                CelularPersonal = rs_cel_personal,
                FotoPersonal = rs_foto_personal,
                EstadoPersonal = rs_est_personal,
                TipoPersonal = rs_tip_personal,
                CategoriaPersonal = rs_cat_personal
            };
        }

        /// <summary>
        /// Actualizar los Datos de un Personal
        /// </summary>
        /// <param name="as_nom_personal">Nombre del Personal</param>
        /// <param name="as_ape_personal">Apellido del Personal</param>
        /// <param name="as_car_personal">Carga del Personal</param>
        /// <param name="as_ema_personal">E-mails del Personal</param>
        /// <param name="as_dir_personal">Direcciones del Personal</param>
        /// <param name="as_tel_personal">Teléfonos del Personal</param>
        /// <param name="as_cel_personal">Celulares del Personal</param>
        /// <param name="as_foto_personal">Foto de Perfil del Personal</param>
        /// <param name="as_est_personal">Estado del Personal</param>
        /// <param name="as_tip_personal">Tipo de Personal</param>
        /// <param name="as_cat_personal">Categoría del Personal</param>
        public void Actualizar(string as_nom_personal, string as_ape_personal, string as_car_personal, string as_ema_personal,
            string as_dir_personal, string as_tel_personal, string as_cel_personal, string as_foto_personal, string as_est_personal, string as_tip_personal,
            string as_cat_personal)
        {
            NombresPersonal = as_nom_personal;
            ApellidosPersonal = as_ape_personal;
            CargoPersonal = as_car_personal;
            EmailPersonal = as_ema_personal;
            DireccionPersonal = as_dir_personal;
            TelefonoPersonal = as_tel_personal;
            CelularPersonal = as_cel_personal;
            FotoPersonal = as_foto_personal;
            EstadoPersonal = as_est_personal;
            TipoPersonal = as_tip_personal;
            CategoriaPersonal = as_cat_personal;
        }

        /// <summary>
        /// Desactivar o Inhabilitar un Personal
        /// </summary>
        public void Desactivar()
        {
            EstadoPersonal = "DESACTIVADO";
        }
    }
}

using SisHorario.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Arquitecturas.Mapeos
{
    public class PersonalMapeo : EntityTypeConfiguration<Personal>
    {
        public PersonalMapeo()
        {
            ToTable("PERSONAL");
            HasKey(k => k.CodigoPersonal);
            Property(p => p.CodigoPersonal).HasColumnName("COD_PERSONAL").IsRequired();
            Property(p => p.NombresPersonal).HasColumnName("NOM_PERSONAL").IsRequired();
            Property(p => p.ApellidosPersonal).HasColumnName("APE_PERSONAL").IsRequired();
            Property(p => p.CargoPersonal).HasColumnName("CAR_PERSONAL").IsRequired();
            Property(p => p.EmailPersonal).HasColumnName("EMA_PERSONAL").IsRequired();
            Property(p => p.DireccionPersonal).HasColumnName("DIR_PERSONAL").IsRequired();
            Property(p => p.TelefonoPersonal).HasColumnName("TEL_PERSONAL").IsRequired();
            Property(p => p.CelularPersonal).HasColumnName("CEL_PERSONAL").IsRequired();
            Property(p => p.FotoPersonal).HasColumnName("FOTO_PERSONAL").IsRequired();
            Property(p => p.EstadoPersonal).HasColumnName("EST_PERSONAL").IsRequired();
            Property(p => p.TipoPersonal).HasColumnName("TIP_PERSONAL").IsRequired();
            Property(p => p.CategoriaPersonal).HasColumnName("CAT_PERSONAL").IsRequired();
        }
    }
}

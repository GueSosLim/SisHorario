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
    public class HoraMapeo : EntityTypeConfiguration<Hora>
    {
        public HoraMapeo()
        {
            ToTable("HORA");
            HasKey(k => k.CodigoHora);
            Property(p => p.CodigoHora).HasColumnName("COD_HORA").IsRequired();
            Property(p => p.DescripcionHora).HasColumnName("DES_HORA").IsRequired();
        }
    }
}

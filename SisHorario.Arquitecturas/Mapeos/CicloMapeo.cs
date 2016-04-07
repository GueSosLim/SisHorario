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
    public class CicloMapeo : EntityTypeConfiguration<Ciclo>
    {
        public CicloMapeo()
        {
            ToTable("CICLO");
            HasKey(k => k.CodigoCiclo);
            Property(p => p.CodigoCiclo).HasColumnName("COD_CICLO").IsRequired(); ///.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.NombreCiclo).HasColumnName("NOM_CICLO").IsRequired();
        }
    }
}

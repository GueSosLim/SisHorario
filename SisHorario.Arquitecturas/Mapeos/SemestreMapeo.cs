using SisHorario.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Arquitecturas.Mapeos
{
    public class SemestreMapeo : EntityTypeConfiguration<Semestre>
    {
        public SemestreMapeo()
        {
            ToTable("SEMESTRE");
            HasKey(k => k.CodigoSemestre);
            Property(p => p.AnioSemestre).HasColumnName("ANIO_SEMESTRE").IsRequired();
            Property(p => p.EstadoSemestre).HasColumnName("EST_SEMESTRE").IsRequired();
            Property(p => p.NombreSemestre).HasColumnName("NOM_SEMESTRE").IsRequired();
            Property(p => p.CodigoPlanEstudio).HasColumnName("COD_PLANESTUDIO").IsRequired();
            HasRequired(m => m.CodPlanEstudio).WithMany().HasForeignKey(m => m.CodigoPlanEstudio);
        }
    }
}

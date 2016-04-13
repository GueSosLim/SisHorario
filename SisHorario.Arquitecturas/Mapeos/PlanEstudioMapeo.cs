using SisHorario.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Arquitecturas.Mapeos
{
    public class PlanEstudioMapeo : EntityTypeConfiguration<PlanEstudio>
    {
        public PlanEstudioMapeo()
        {
            ToTable("PLANESTUDIO");
            HasKey(k => k.CodigoPlanEstudio);
            Property(p => p.CodigoPlanEstudio).HasColumnName("COD_PLANESTUDIO").IsRequired();
            Property(p => p.DescripcionPlanEstudio).HasColumnName("DES_PLANESTUDIO").IsRequired();
            Property(p => p.EstadoPlanEstudio).HasColumnName("EST_PLANESTUDIO").IsRequired();
            Property(p => p.FechaCreacionPlanEstudio).HasColumnName("FEC_PLANESTUDIO").IsRequired();
            Property(p => p.NombrePlanEstudio).HasColumnName("NOM_PLANESTUDIO").IsRequired();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using SisHorario.Dominio;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisHorario.Arquitecturas.Mapeos
{
    class AmbienteMapeo : EntityTypeConfiguration<Ambiente>
    {
        public AmbienteMapeo()
        {
            ToTable("AMBIENTE");
            HasKey(k => k.CodigoAmbiente);
            Property(p => p.CodigoAmbiente).HasColumnName("COD_AMBIENTE").IsRequired();
            Property(p => p.CapacidadAmbiente).HasColumnName("CAP_AMBIENTE").IsRequired();
            Property(p => p.NombreAmbiente).HasColumnName("NOM_AMBIENTE").IsRequired();
            Property(p => p.TipoAmbiente).HasColumnName("TIP_AMBIENTE").IsRequired();
        }
    }
}

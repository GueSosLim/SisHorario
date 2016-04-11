using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Arquitecturas.Mapeos
{
    class DisponibilidadPersonalMapeo : EntityTypeConfiguration<DisponibilidadPersonal>
    {
        public DisponibilidadPersonalMapeo() {
            ToTable("DISPONIBILIDADPERSONAL");
            HasKey(k => k.CodigoDisponibilidad);
            Property(p => p.CodigoPersonal).HasColumnName("COD_DISPONIBILIDAD").IsRequired();
            Property(p => p.CodigoHora).HasColumnName("COD_HORA").IsRequired();
            Property(p => p.CodigoPersonal).HasColumnName("COD_PERSONAL").IsRequired();
            Property(p => p.CodigoSemestre).HasColumnName("COD_SEMESTRE").IsRequired();
            Property(p => p.Dia).HasColumnName("DIA").IsRequired();
        }
    }
}

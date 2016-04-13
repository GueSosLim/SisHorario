using SisHorario.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Arquitecturas.Mapeos
{
    public class DisponibilidadPersonalMapeo : EntityTypeConfiguration<DisponibilidadPersonal>
    {
        public DisponibilidadPersonalMapeo() {
            ToTable("DISPONIBILIDADPERSONAL");
            HasKey(k => k.CodigoDisponibilidadPersonal);
            Property(p => p.CodigoDisponibilidadPersonal).HasColumnName("COD_DISPONIBILIDADPERSONAL").IsRequired();
            Property(p => p.Dia).HasColumnName("DIA").IsRequired();
            Property(p => p.CodigoHora).HasColumnName("COD_HORA").IsRequired();
            Property(p => p.CodigoPersonal).HasColumnName("COD_PERSONAL").IsRequired();
            Property(p => p.CodigoSemestre).HasColumnName("COD_SEMESTRE").IsRequired();
            HasRequired(m => m.CodHora).WithMany().HasForeignKey(m => m.CodigoHora);
            HasRequired(m => m.CodPersonal).WithMany().HasForeignKey(m => m.CodigoPersonal);
            HasRequired(m => m.CodSemestre).WithMany().HasForeignKey(m => m.CodigoSemestre);
        }
    }
}

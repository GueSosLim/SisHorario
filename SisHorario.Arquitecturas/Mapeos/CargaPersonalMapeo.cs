using SisHorario.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Arquitecturas.Mapeos
{
    public class CargaPersonalMapeo : EntityTypeConfiguration<CargaPersonal>
    {
        public CargaPersonalMapeo() {
            ToTable("CARGAPERSONAL");
            HasKey(k => k.CodigoCargaPersonal);
            Property(p => p.CodigoCargaPersonal).HasColumnName("COD_CARGAPERSONAL").IsRequired();
            Property(p => p.Seccion).HasColumnName("SECCION").IsRequired();
            Property(p => p.CodigoCurso).HasColumnName("COD_CURSO").IsRequired();
            Property(p => p.CodigoCiclo).HasColumnName("COD_CICLO").IsRequired();
            Property(p => p.CodigoPersonal).HasColumnName("COD_PERSONAL").IsRequired();
            Property(p => p.CodigoSemestre).HasColumnName("COD_SEMESTRE").IsRequired();
            HasRequired(m => m.CodPersonal).WithMany().HasForeignKey(m => m.CodigoPersonal);
            HasRequired(m => m.CodCiclo).WithMany().HasForeignKey(m => m.CodigoCiclo);
            HasRequired(m => m.CodSemestre).WithMany().HasForeignKey(m => m.CodigoSemestre);
            HasRequired(m => m.CodCurso).WithMany().HasForeignKey(m => m.CodigoCurso);
        }
    }
}

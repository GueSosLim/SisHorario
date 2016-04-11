using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Arquitecturas.Mapeos
{
    class CargaPersonalMapeo : EntityTypeConfiguration<CargaPersonal>
    {
        public CargaPersonalMapeo() {
            ToTable("CARGAPERSONAL");
            HasKey(k => k.CodigoCargaPersonal);
            Property(p => p.CodigoCargaPersonal).HasColumnName("COD_CARGAPERSONAL").IsRequired();
            Property(p => p.CodigoCurso).HasColumnName("COD_CURSO").IsRequired();
            Property(p => p.CodigoCiclo).HasColumnName("COD_CICLO").IsRequired();
            Property(p => p.CodigoPersonal).HasColumnName("COD_PERSONAL").IsRequired();
            Property(p => p.CodigoSemestre).HasColumnName("COD_SEMESTRE").IsRequired();
            Property(p => p.Seccion).HasColumnName("SECCION").IsRequired();
        }
    }
}

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
    public class HorarioMapeo : EntityTypeConfiguration<Horario>
    {
        public HorarioMapeo()
        {
            ToTable("HORARIO");
            HasKey(k => k.CodigoHorario);
            Property(p => p.CodigoHorario).HasColumnName("COD_HORARIO").IsRequired();
            Property(p => p.CantidadAlumnos).HasColumnName("CANT_ALUMNOS").IsRequired();
            Property(p => p.Seccion).HasColumnName("SEC_HORARIO").IsRequired();
            Property(p => p.DiaHorario).HasColumnName("DIA_HORARIO").IsRequired();
            Property(p => p.Horas).HasColumnName("HOR_HORARIO").IsRequired();
            Property(p => p.CodigoPersonal).HasColumnName("COD_PERSONAL").IsRequired();
            Property(p => p.CodigoCiclo).HasColumnName("COD_CICLO").IsRequired();
            Property(p => p.CodigoSemestre).HasColumnName("COD_SEMESTRE").IsRequired();
            Property(p => p.CodigoAmbiente).HasColumnName("COD_AMBIENTE").IsRequired();
            Property(p => p.CodigoCurso).HasColumnName("COD_CURSO").IsRequired();
            HasRequired(m => m.CodPersonal).WithMany().HasForeignKey(m => m.CodigoPersonal);
            HasRequired(m => m.CodCiclo).WithMany().HasForeignKey(m => m.CodigoCiclo);
            HasRequired(m => m.CodSemestre).WithMany().HasForeignKey(m => m.CodigoSemestre);
            HasRequired(m => m.CodAmbiente).WithMany().HasForeignKey(m => m.CodigoAmbiente);
            HasRequired(m => m.CodCurso).WithMany().HasForeignKey(m => m.CodigoCurso);
        }
    }
}

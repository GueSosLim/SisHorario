﻿using SisHorario.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SisHorario.Arquitecturas.Mapeos
{
    public class CursoMapeo : EntityTypeConfiguration<Curso>
    {
        public CursoMapeo()
        {
            ToTable("CURSO");
            HasKey(k => k.CodigoCurso);
            Property(p => p.CodigoCurso).HasColumnName("COD_CURSO").IsRequired();
            Property(p => p.CodigoCiclo).HasColumnName("COD_CICLO").IsRequired();
            Property(p => p.CodigoDelCurso).HasColumnName("COD_DCURSO").IsRequired();
            Property(p => p.CodigoPlanEstudio).HasColumnName("COD_PLANESTUDIOS").IsRequired();
            Property(p => p.ColorCurso).HasColumnName("COL_CURSO").IsRequired();
            Property(p => p.CreditoCurso).HasColumnName("CRED_CURSO").IsRequired();
            Property(p => p.FechaCreacion).HasColumnName("FEC_CREACION").IsRequired();
            Property(p => p.HoraPractica).HasColumnName("HORA_PRACTICA").IsRequired();
            Property(p => p.HoraTeoria).HasColumnName("HORA_TEORIA").IsRequired();
            Property(p => p.NombreCurso).HasColumnName("NOM_CURSO").IsRequired();
            Property(p => p.PreRequisitoCurso).HasColumnName("PREREQ_CURSO").IsRequired();
            Property(p => p.TipoCurso).HasColumnName("TIPO_CURSO").IsRequired();
            Property(p => p.TotalHoras).HasColumnName("TOT_HORAS").IsRequired();
            HasRequired(m => m.CodCiclo).WithMany().HasForeignKey(m => m.CodigoCiclo);
            HasRequired(m => m.CodPlanEstudio).WithMany().HasForeignKey(m => m.CodigoPlanEstudio);
        }
    }
}

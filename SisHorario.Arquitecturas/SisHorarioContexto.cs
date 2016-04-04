﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using SisHorario.Dominio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisHorario.Infraestructura
{
    public class SisHorarioContexto : DbContext
    {
        public SisHorarioContexto() : base("Conexion")
        {
            Database.SetInitializer<SisHorarioContexto>(new InicializadorDB());
        }

        public DbSet<Ambiente> Ambientes { get; set; }
        public DbSet<CargaPersonal> CargaPersonals { get; set; }
        public DbSet<Ciclo> Ciclos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<DisponibilidadPersonal> DisponibilidadPersonals { get; set; }
        public DbSet<Hora> Horas { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<PlanEstudio> PlanEstudios { get; set; }
        public DbSet<Semestre> Semestres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ambiente>().HasKey(k => k.CodigoAmbiente);
            modelBuilder.Entity<CargaPersonal>().HasKey(k => k.CodigoCargaPersonal);
            modelBuilder.Entity<Ciclo>().HasKey(k => k.CodigoCiclo);
            modelBuilder.Entity<Curso>().HasKey(k => k.CodigoCurso);
            modelBuilder.Entity<DisponibilidadPersonal>().HasKey(k => k.CodigoDisponibilidadPersonal);
            modelBuilder.Entity<Hora>().HasKey(k => k.CodigoHora);
            modelBuilder.Entity<Horario>().HasKey(k => k.CodigoHorario);
            modelBuilder.Entity<Personal>().HasKey(k => k.CodigoPersonal);
            modelBuilder.Entity<PlanEstudio>().HasKey(k => k.CodigoPlanEstudio);
            modelBuilder.Entity<Semestre>().HasKey(k => k.CodigoSemestre);
        }
    }
}
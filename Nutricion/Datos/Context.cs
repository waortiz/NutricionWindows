using Nutricion.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Datos
{
    public class Context: DbContext
    {
        public Context()
            : base("name=Nutricion") 
        {
            Database.SetInitializer(new Initializer());
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<EstadoCivil> EstadosCiviles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumento>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.TipoDocumento)
                .HasForeignKey(p => p.IdTipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstadoCivil>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.EstadoCivil)
                .HasForeignKey(p => p.IdEstadoCivil)
                .WillCascadeOnDelete(false);

        }
    }
}
using H1.Model.Entity;
using H1.Model.Entity.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext():base("H1Connection")
        {
        #if DEBUG
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        #endif
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            LoadConfigurations(modelBuilder.Configurations);
            base.OnModelCreating(modelBuilder);
        }
        protected void LoadConfigurations(ConfigurationRegistrar configurations)
        {
            configurations.Add(new PacienteConfiguration());
        }


        public virtual DbSet<Usuario> Usuarios { get; set; }

        public virtual IDbSet<Paciente> Pacientes { get; set; }

    }
}

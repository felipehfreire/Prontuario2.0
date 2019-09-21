using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace H1.Model.Entity.Configuration
{
    public class PacienteConfiguration : EntityTypeConfiguration<Paciente> 
    {
        public PacienteConfiguration()
        {
            ToTable("[@FLAGCADPAC]")
              .HasKey(t => t.Code);
            //Property(u => u.Code).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
        }
          
    }
}

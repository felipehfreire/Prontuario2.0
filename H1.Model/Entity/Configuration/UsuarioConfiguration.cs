using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.Entity.Configuration
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario> 
    {
        public UsuarioConfiguration()
        {
            ToTable("TB_PRT_USUARIO");
            HasKey(u => u.Id);
        }
          
    }
}

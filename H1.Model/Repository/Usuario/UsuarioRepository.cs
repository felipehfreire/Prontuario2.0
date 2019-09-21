using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.Repository.Usuario
{
    public class UsuarioRepository : RepositoryBase
    {
        public int GetUserByCodeColaborador(string code)
        {
            return this.Context.Database.SqlQuery<int>("").FirstOrDefault();
        }
    }
}

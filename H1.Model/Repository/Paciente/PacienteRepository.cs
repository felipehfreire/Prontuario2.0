using System.Collections.Generic;
using System.Linq;


namespace H1.Model.Repository.Paciente
{
    public class PacienteRepository : RepositoryBase
    {
        public List<Entity.Paciente> PesquisarPacienteS2(string query)
        {
            return this.Context.Pacientes.Where(p => p.U_NOMPAC.ToUpper().StartsWith(query.ToUpper()) || p.U_CODPAC.ToUpper().StartsWith(query.ToUpper())&& p.U_NUMEROPRONTUARIO != null && !p.U_NUMEROPRONTUARIO.Equals("")).ToList();
        }
    }
}

using H1.Model.DTO.Agenda;
using H1.Model.SQLS.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.Repository.Agenda
{
    public class AgendaRepository : RepositoryBase
    {
        public List<AgendaMedicaDTO> GetAgendaMedica(string codigoPaciente,string idUser)
        {
            var codigoColaboradorSAP = this.Context.Database.SqlQuery<string>(string.Format("select CodigoColaboradorSAP from tb_prt_usuario where Id = '{0}'", idUser)).SingleOrDefault();
            if (string.IsNullOrEmpty(codigoColaboradorSAP))
            {
                //TODO La~çar exepetion
                //return null;
            }
            string sql = AgendaSQL.AgendaMedicas(codigoPaciente, codigoColaboradorSAP);
            return this.Context.Database.SqlQuery<AgendaMedicaDTO>(sql).ToList() ;
        }
    }
}

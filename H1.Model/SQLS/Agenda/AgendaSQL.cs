using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.SQLS.Agenda
{
    static class AgendaSQL
    {
        public const string AGENDAS_MEDICAS = @"SELECT 
	            [@FLAGAGENDCH1].U_HORAGE Hora,
	            U_DESPAC NomePaciente, 
	            convert(NVARCHAR, [@FLAGAGENDCH1].U_DataAge, 103) DataDocumento, 
	            [@FLAGAGENDPROC].CODE Codigodocumento, 
	            U_CODTIPA Tipodoc, 
	            [@FLAGAGENDPROC].U_STA as Status, 
	            U_CodPac CodigoPaciente
            FROM 
	            [@FLAGAGENDPROC]
	            INNER JOIN [@FLAGAGENDCH1] 
		            ON [@FLAGAGENDPROC].U_CODAGE = [@FLAGAGENDCH1].U_CODAGE
            WHERE 
	            UPPER([@FLAGAGENDPROC].U_STA) <> 'FALTA'
	            AND   UPPER([@FLAGAGENDPROC].U_STA) <> 'REMARCADO'
	            AND   UPPER([@FLAGAGENDPROC].U_STA) <> 'CANCELADO' ";
        public static string  AgendaMedicas(string codigoPaciente, string codigoColaboradorSAP)
        {
            var sql = AGENDAS_MEDICAS;
            if (!string.IsNullOrWhiteSpace(codigoColaboradorSAP))
            {
                sql += string.Format("AND [@FLAGAGENDCH1].U_CodProf = '{0}' ", codigoColaboradorSAP);
            }

            if (!string.IsNullOrWhiteSpace(codigoPaciente))
                sql += string.Format("AND U_CodPac = '{0}'", codigoPaciente);
            sql += " order by [@FLAGAGENDCH1].U_DataAge ,[@FLAGAGENDCH1].U_HORAGE ";
            return sql;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.DTO.Paciente
{
    public class PacienteDTO
    {
        /// <summary>
        /// código paciente
        /// </summary>
        public string U_CODPAC { get; set; }
        /// <summary>
        /// nome paciente
        /// </summary>
        public int U_NOMPAC { get; set; }
        /// <summary>
        /// prontuário paciente
        /// </summary>
        public string U_NUMEROPRONTUARIO { get; set; }

        //unused yet
        // U_DATANASCIMENTO, 
        //U_NUMEROPRONTUARIO, 
        //U_DTINCLUSAOREGISTRO, 
        //U_NOMEDAMAE, 
        //U_NOMEDOPAI,      
        //U_SEXO, 
        //U_TEL,
        //U_ENDBAI
    }
}

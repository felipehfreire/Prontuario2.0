using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.Entity
{
    public class Paciente
    {
        /// <summary>
        /// 
        /// </summary>
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Code { get; set; }
        /// <summary>
        /// código paciente
        /// </summary>
        public string U_CODPAC { get; set; }
        /// <summary>
        /// nome paciente
        /// </summary>
        public string U_NOMPAC { get; set; }
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

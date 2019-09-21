using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.DTO.Agenda
{
    public class AgendaMedicaDTO
    {
        public string Hora { get; set; }
        public string NomePaciente { get; set; }
        public string DataDocumento { get; set; }
        public string Codigodocumento { get; set; }
        public string Tipodoc { get; set; }
        public string Status { get; set; }
        public string CodigoPaciente { get; set; }
    }
}

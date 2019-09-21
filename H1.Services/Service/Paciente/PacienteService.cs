using H1.Model.Repository.Paciente;
using H1.Services.ViewModel.Select2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Services.Service.Paciente
{
    public class PacienteService : ServiceBase
    {
        private PacienteRepository _pacienteRepository;
        public PacienteService(PacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public List<ResultS2ViewModel> PesquisarPacienteS2(string q)
        {

            var x = _pacienteRepository.PesquisarPacienteS2(q).Select(d => new ResultS2ViewModel { id = d.U_CODPAC, text = d.U_NOMPAC, InfoExtra = d.U_NUMEROPRONTUARIO }).ToList();
            return x;
        }
    }
}

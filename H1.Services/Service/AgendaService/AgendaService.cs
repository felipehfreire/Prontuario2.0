using System.Collections.Generic;
using AutoMapper;
using H1.Model.DTO.Agenda;
using H1.Model.Repository.Agenda;
using H1.Services.ViewModel.Agenda;
using H1.Services.ViewModel.Select2;
using H1.Model.Repository.Paciente;
using System.Linq;

namespace H1.Services.Service.AgendaService
{
    public class AgendaService : ServiceBase
    {
        private AgendaRepository _agendaRepository;
        private PacienteRepository _pacienteRepository;

        public AgendaService(AgendaRepository agendaRepository, PacienteRepository pacienteRepository)
        {
            _agendaRepository = agendaRepository;
            _pacienteRepository = pacienteRepository;
        }

        public List<AgendaMedicaViewModel> GetAgendaMedica(string codigoPaciente, string idUser)
        {
            var x = _agendaRepository.GetAgendaMedica(codigoPaciente, idUser);

            var b = Mapper.Map<List<AgendaMedicaDTO>, List<AgendaMedicaViewModel>>(x);
            return b;
        }

        public List<ResultS2ViewModel> PesquisarPacienteS2(string q)
        {
            
            var x = _pacienteRepository.PesquisarPacienteS2(q).Select(d => new ResultS2ViewModel { id=d.U_CODPAC,text= d.U_NOMPAC }).ToList();
                return x;
        }
    }
}

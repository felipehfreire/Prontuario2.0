using AutoMapper;
using H1.Model.DTO.Agenda;
using H1.Services.ViewModel.Agenda;

namespace H1.Services.AutoMapper
{
    internal class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AgendaMedicaViewModel, AgendaMedicaDTO>();
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1.Services.ViewModel.Usuario;
using H1.Model.Validators;
using H1.Model.Repository.Usuario;
using H1.Model.Specifications.SAP;
using H1.Services.Validations;

namespace H1.Services.Service.Usuario
{
    public class UsuarioService : ServiceBase
    {
        private UsuarioRepository _usuarioRepository;
        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public H1ValidationResult ValidateNewUser(UsuarioViewModel userVm)
        {
            var retorno = new H1ValidationResult();
            toValidate.Add(new IsCodigoColaboradorSapExistenteSpecification(_usuarioRepository.GetUserByCodeColaborador).IsSatisfiedBy(userVm.CodigoColaboradorSAP));
            toValidate.Add(new IsCodigoColaboradorSapAtribuidoSpecification(_usuarioRepository.GetUserByCodeColaborador).IsSatisfiedBy(userVm.CodigoColaboradorSAP));

            foreach (var item in toValidate)
            {
                if (item !=ValidationResult.Success)
                {
                    retorno.Errors.Add(item.ErrorMessage);
                }
            }

            
            return retorno;
        }
    }
}


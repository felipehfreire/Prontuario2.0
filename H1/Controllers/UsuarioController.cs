using H1.ClaimsFilter;
using H1.Services.Service.Usuario;
using H1.Services.Validations;
using H1.Services.ViewModel.Usuario;
using H1Security.Identity.Configuration;
using H1Security.Identity.IdentityModel;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace H1.Controllers
{
    [Authorize]
    [ClaimsAuthorize("AdminUsuario", "true")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;
        private ApplicationUserManager _userManager;
        public UsuarioController(UsuarioService usuarioService, ApplicationUserManager userManager)
        {
            _usuarioService = usuarioService;
            _userManager = userManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterUser(UsuarioViewModel userVm)
        {
            if (ModelState.IsValid)
            {
                H1ValidationResult resultR = _usuarioService.ValidateNewUser(userVm);
                if (!resultR.Succeeded)
                {
                    AddErrors(resultR);
                    return View(userVm);
                }

                var user = new ApplicationUser
                {
                    Tratamento = userVm.Tratamento,
                    Nome = userVm.Nome,
                    CodigoColaboradorSAP = userVm.CodigoColaboradorSAP,
                    CodigoEmpresa = userVm.CodigoEmpresa,
                    Code = userVm.Code
                };

            var result = await _userManager.CreateAsync(user, userVm.Password);
            if (!result.Succeeded)
            {
                
            }
            else
                AddErrors(result);
            }
            return View(userVm);
        }

        
    }
}
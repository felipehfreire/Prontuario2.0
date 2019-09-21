using H1.Model.Repository.Agenda;
using H1.Services.Service.AgendaService;
using H1Security.Identity.Configuration;
using H1Security.Identity.IdentityContext;
using H1Security.Identity.IdentityModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;
using H1.Model.Repository.Paciente;
using H1.Services.Service.Paciente;
using H1.Services.Service.Usuario;
using H1.Model.Repository.Usuario;

namespace H1IoC
{
    public class H1Container
    {
        //Lifestyle Description
        //Transient:each time the service is requested 
        //Scoped:For every request
        //Singleton:one instance of the registered service 
        public static void RegisterServices(Container container)
        {
            #region Identity
            container.Register<ApplicationIdentityDbContext>(Lifestyle.Scoped);
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationIdentityDbContext()), Lifestyle.Scoped);
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>(), Lifestyle.Scoped);
            container.Register<ApplicationRoleManager>(Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);
            #endregion

            #region Services
            container.Register<AgendaService>(Lifestyle.Scoped);
            container.Register<PacienteService>(Lifestyle.Scoped);
            container.Register<UsuarioService>(Lifestyle.Scoped);
            #endregion

            #region Repositorys
            container.Register<AgendaRepository>(Lifestyle.Scoped);
            container.Register<PacienteRepository>(Lifestyle.Scoped);
            container.Register<UsuarioRepository>(Lifestyle.Scoped);
            #endregion

            //container.RegisterPerWebRequest<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
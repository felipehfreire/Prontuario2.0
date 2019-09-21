using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace H1Security.Identity.IdentityModel
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Clients = new Collection<Client>();
            EmailConfirmed = false;
        }

        public string Nome { get; set; }
        public string Tratamento { get; set; }
        public string CodigoColaboradorSAP { get; set; }
        public int? CodigoEmpresa { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Client> Clients { get; set; }

        [NotMapped]
        public string CurrentClientId { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            //todo after save the user and managment
            //addd claims to be useful like CodigoColaboradorSAP, Code, and CodigoEmpresa
            //TODO
            return userIdentity;
        }


    }
}
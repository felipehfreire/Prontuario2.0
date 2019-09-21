using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Model.Entity
{
    public class Usuario
    {
        public Usuario()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Tratamento { get; set; }
        public virtual string CodigoColaboradorSAP { get; set; }
        public virtual int? CodigoEmpresa { get; set; }
        public virtual string Code { get; set; }
        public virtual string Email { get; set; }
        public virtual bool EmailConfirmed { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual bool PhoneNumberConfirmed { get; set; }
        public virtual bool TwoFactorEnabled { get; set; }
        public virtual DateTime? LockoutEndDateUtc { get; set; }
        public virtual bool LockoutEnabled { get; set; }
        public virtual int AccessFailedCount { get; set; }
        public virtual string UserName { get; set; }
    }
}

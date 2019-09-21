using H1Security.Identity.IdentityModel;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Security.Identity.IdentityContext
{
    public class ApplicationIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        //public ApplicationDbContext()
        //    : base("DefaultConnection", throwIfV1Schema: false)
        //{
        //}


        public ApplicationIdentityDbContext()
            : base("H1Connection", throwIfV1Schema: false)
        {
        }

        public DbSet<Client> Client { get; set; }

        public DbSet<Claims> Claims { get; set; }

        public static ApplicationIdentityDbContext Create()
        {
            return new ApplicationIdentityDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<IdentityUser>().ToTable("TB_PRT_H1_USERS");//.Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<ApplicationUser>().ToTable("TB_PRT_USUARIO2");//.Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("TB_PRT_USER_ROLES");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("TB_PRT_USER_LOGINS");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("TB_PRT_USER_CLAIMS");
            modelBuilder.Entity<IdentityRole>().ToTable("TB_PRT_ROLES");
        }
    }
}

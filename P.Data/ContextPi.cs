using Microsoft.AspNet.Identity.EntityFramework;
using P.Data.Configurations;
using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Data
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class ContextPi: IdentityDbContext<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public static ContextPi Create()
        {
            return new ContextPi();
        }
        static ContextPi()
        {
            Database.SetInitializer<ContextPi>(null);
        }
        public ContextPi():base("name=BibDB")
        {

        }
       

       // public DbSet<User> Users { get; set; }
        
        //public DbSet<Address> Addresses { get; set; }
        public DbSet<AmendmentC> AmendmentsC { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<FiscalPower> FiscalPowers { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Garage> Garages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<RCPrice> RCPrices { get; set; }
        public DbSet<Sinister> Sinisters { get; set; }
        public DbSet<Third> Thirds { get; set; }
        public DbSet<VDCFranchiseLevel> VDCFranchiseLevels { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Warranty> Warranties { get; set; }
        public DbSet<WarrantyAssignment> WarrantyAssignments { get; set; }
        public DbSet<WreckReport> WReports { get; set; }
        
        

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());


            modelBuilder.Entity<User>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CustomUserClaim>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CustomUserRole>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            modelBuilder.Entity<User>().Property(r => r.UserName).HasColumnName("Login");
            modelBuilder.Entity<User>().Property(r => r.PasswordHash).HasColumnName("password");
            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<IdentityUserRole>()
            .HasKey(r => new { r.UserId, r.RoleId })
            .ToTable("AspNetUserRoles");


            //modelBuilder.Entity<IdentityUserLogin>()
            //    .HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId })
            //    .ToTable("AspNetUserLogins");
            modelBuilder.Entity<HistoryRow>().HasKey(h => h.MigrationId);
            modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(200).IsRequired();
            //  modelBuilder.Entity<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>()
            //    .Property(c => c.Name).HasMaxLength(128).IsRequired();

            //base.OnModelCreating(modelBuilder);

            //   modelBuilder.Entity<ApplicationUser>().ToTable("Clients");

            //   modelBuilder.Entity<IdentityUserClaim>().ToTable("identityroles");
            //modelBuilder.Entity<IdentityUserRole>().ToTable("identityuserclaims");
        }


    }
}

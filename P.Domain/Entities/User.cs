using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;

namespace P.Domain.Entities
{
    public class User : IdentityUser<int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        [Key]
        public String idUser { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
        public string role { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Classe> Classes { get; set; }
        //public string email { get; set; }



        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User, int> manager)
        {
            // Note the authenticationType must match the one defined in
            // CookieAuthenticationOptions.AuthenticationType 
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here 
            return userIdentity;


        }
    }
    public class CustomUserLogin : IdentityUserLogin<int>
    {
        public int Id { get; set; }

    }
    public class CustomUserRole : IdentityUserRole<int>
    {
        public int Id { get; set; }
    }
    public class CustomUserClaim : IdentityUserClaim<int>
    {

    }
    public class CustomRole : IdentityRole<int, CustomUserRole>
    {
        public CustomRole() { }
        public CustomRole(string name) { Name = name; }
    }

    
}

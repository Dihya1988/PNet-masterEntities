using Microsoft.AspNet.Identity.EntityFramework;
using PWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using P.Data;

using Microsoft.AspNet.Identity;
using P.Domain.Entities;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ASPNetIdentity
{
    public class IdentityConfig
    {
        /* public class ApplicationUserStore : UserStore<User>
         {
             public ApplicationUserStore(UserDbContext context) : base(context)
             {
             }
         }

         public class ApplicationUserManager : UserManager<User>
         {
             public ApplicationUserManager(IUserStore<User> store) : base(store)
             {
             }
         }*/

        // Configurer l'application que le gestionnaire des utilisateurs a utilisée dans cette application. UserManager est défini dans ASP.NET Identity et est utilisé par l'application.
        public class ApplicationUserManager : UserManager<User, int>
        {
            public ApplicationUserManager(IUserStore<User, int> store)
                : base(store)
            {
            }
            public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
            {
                var manager = new ApplicationUserManager(new CustomUserStore(context.Get<ContextPi>()));
                // Configurer la logique de validation pour les noms d'utilisateur 
                manager.UserValidator = new UserValidator<User, int>(manager)
                {
                    AllowOnlyAlphanumericUserNames = false,
                    RequireUniqueEmail = true
                };

                // Configurer la logique de validation pour les mots de passe
                manager.PasswordValidator = new PasswordValidator
                {
                    RequiredLength = 6,
                    RequireNonLetterOrDigit = true,
                    RequireDigit = true,
                    RequireLowercase = true,
                    RequireUppercase = true,
                };

                return manager;
            }
        }

        // Configurer le gestionnaire de connexion d'application qui est utilisé dans cette application.
        public class ApplicationSignInManager : SignInManager<User, int>
        {
            public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
                : base(userManager, authenticationManager)
            {
            }

            public override Task<ClaimsIdentity> CreateUserIdentityAsync(User user)
            {
                return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
            }

            public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
            {
                return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
            }
        }
    }
        }
    


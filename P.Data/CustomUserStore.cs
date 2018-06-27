using Microsoft.AspNet.Identity.EntityFramework;
using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Data
{
   public  class CustomUserStore : UserStore<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public CustomUserStore(ContextPi context) : base(context)
        {
        }

       /* public CustomUserStore(ContextPi context) : base(context)
        {

        }*/
    }
}

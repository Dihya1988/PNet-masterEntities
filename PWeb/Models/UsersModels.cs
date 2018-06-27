using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace PWeb.Models
{
    public class UsersModels 
    {
        public String idUser { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string Address { get; set; }
        public string role { get; set; }
        public string Email { get; set; }


        // public virtual ICollection<TRole> Roles { get; }

    }
}
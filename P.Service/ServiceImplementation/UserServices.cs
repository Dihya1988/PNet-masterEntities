using P.Data.Infrastructure;
using P.Domain.Entities;
using P.Service.ServiceInterface;
using PService.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Service.ServiceImplementation
{
    public class UserServices : Service<User>, IUserService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public UserServices()
           : base(ut)
        {
        }
        public User FindRoleByName(string name)
        {
            IEnumerable<User> ls = this.GetMany().OrderBy(p => p.FirstName).Where(p => p.FirstName == name).Take(1);
            User c = new User();
            foreach (var i in ls)
            {
                c.FirstName = i.FirstName;
                c.role = i.role;
            }
            return c;
        }
    }
}

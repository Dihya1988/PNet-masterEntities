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
    class AdminServices : Service<User>, IAdminService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork u = new UnitOfWork(dbf);

        public AdminServices()
           : base(u)
        { }

       
    }
}

using P.Data.Infrastructure;
using P.Service.ServiceInterface;
using PService.Pattern;
using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Service.ServiceImplementation
{
    public class VehicleService : Service<Vehicle>, IVehicleService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);


        public VehicleService()
           : base(ut)
        {
        }



    }
}

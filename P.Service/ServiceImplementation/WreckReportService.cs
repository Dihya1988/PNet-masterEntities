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
    public class WreckReportService : Service<WreckReport>, IWreckReportService
    {

        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);


        public WreckReportService()
           : base(ut)
        {
        }




    }
}

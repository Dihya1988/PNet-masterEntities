using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private ContextPi dataContext;
        public ContextPi DataContext { get { return dataContext; } }

        ContextPi IDatabaseFactory.DataContext
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DatabaseFactory()
        {
            dataContext = new ContextPi();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Domain.Entities;

namespace P.Data.Configurations
{
    class AddressConfiguration : ComplexTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {

        }
    }
}

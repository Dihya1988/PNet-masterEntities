using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class FiscalPower
    {
        [Key]
        public int IdFiscalPower { get; set; }
        public int FPower { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<RCPrice> RCPrices { get; set; }
    }
}

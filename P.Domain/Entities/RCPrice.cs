using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class RCPrice
    {
        [Key]
        public int idRCP { get; set; }
        public float price { get; set; }

        public ICollection<RCPrice> RCPrices { get; set; }
        public virtual Classe classe { get; set; }
        public virtual FiscalPower fiscalPower { get; set; }
    }
}

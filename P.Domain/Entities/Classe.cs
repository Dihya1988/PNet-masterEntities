using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Classe
    {
        [Key]
        public int idCla { get; set; }
        public int classe { get; set; }
        public ICollection<Classe> Classes { get; set; }
        public virtual User user { get; set; }
        public virtual ICollection<RCPrice> RCPrices { get; set; }

    }
}

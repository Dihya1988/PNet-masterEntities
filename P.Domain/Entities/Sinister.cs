using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Sinister
    {
        [Key]
        public int IdSinister { get; set; }

        public virtual Garage Garage { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}

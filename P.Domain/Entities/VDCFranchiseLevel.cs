using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class VDCFranchiseLevel
    {
        [Key]
        public int idVDCFL { get; set; }
        public int FLevel { get; set; }
        public double BPrice { get; set; }
        public double PPrice { get; set; }
        public ICollection<VDCFranchiseLevel> VDCFranchiseLevels { get; set; }
        public virtual ICollection<Warranty> Warranties { get; set; }

    }
}

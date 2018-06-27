using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Warranty
    {
        [Key]
        public int idWrr { get; set; }
        public string title { get; set; }
        public double cPrice { get; set; }
        public double pPrice { get; set; }
        public int mandatory { get; set; }
        public ICollection<Warranty> Warranties { get; set; }
        public virtual ICollection<WarrantyAssignment> WarrantyAssignments { get; set; }
        public virtual VDCFranchiseLevel VDCFranchiseLevel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class WarrantyAssignment
    {
        [Key]
        [Column(Order = 1)]
        public int idCont { get; set; }
        [Key]
        [Column(Order = 2)]
        public int idWrr { get; set; }
        public DateTime date { get; set; }
        public ICollection<WarrantyAssignment> WarrantyAssignments { get; set; }
        public virtual Warranty warranty { get; set; }
        public virtual Contract contract { get; set; }

    }
}
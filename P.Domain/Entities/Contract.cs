using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Contract
    {
        [Key]
        public int idCont { get; set; }
        public int codeCont { get; set; }
        public DateTime dateCre { get; set; }
        public DateTime dateDeb { get; set; }
        public DateTime dateFin { get; set; }
        public double paiement { get; set; }
        public Boolean reconductible { get; set; }
        public String state { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<WarrantyAssignment> WarrantyAssignments { get; set; }
        public virtual User user { get; set; }
        public virtual Vehicle vehicle { get; set; }

    }
}

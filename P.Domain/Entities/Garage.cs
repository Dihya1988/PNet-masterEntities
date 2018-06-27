using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Garage
    {
        [Key]
        public String IdGarage { get; set; }
        public String NameGarage { get; set; }

        public String PlaceGarage { get; set; }
        public String ManagerGarage { get; set; }

        //*Sinistre 1Garage

        virtual public ICollection<Sinister> Sinister { get; set; }

    }
}

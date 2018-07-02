using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVehicle { get; set; }

        [Required(ErrorMessage = "Registration is required")]
        [MaxLength(15)]
        public String Registration { get; set; }

        public String Brand { get; set; }

        public String Model { get; set; }

        [Display(Name = "Seats Number")]
        public int SeatsNumber { get; set; }

        [Display(Name = "Value when new")]
        [Required(ErrorMessage = "This value is required")]
        public double ValueWhenNew { get; set; }

        [Display(Name = "Value when venal")]
        [Required(ErrorMessage = "This value is required")]
        public double ValueWhenVenal { get; set; }

        [Display(Name = "Initial Trafic Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime InitTraficDate { get; set; }

        public virtual ICollection<WreckReport> WReports { get; set; }
        public virtual ICollection<Sinister> Sinisters { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Folder> Folders { get; set; }

        //   public int? IdUser { get; set; }

        public virtual User Users { get; set; }

        //    public int? IdFiscalPower { get; set; }

        public virtual FiscalPower FiscalPowers { get; set; }


    }
}
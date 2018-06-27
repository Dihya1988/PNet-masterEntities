using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Folder
    {
        [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int IdFolder { get; set; }

    [Display(Name = "Folder Title")]
    public String FolderTitle { get; set; }

    [Display(Name = "Modification Date")]
    [DataType(DataType.DateTime)]
    public DateTime ModificationDate { get; set; }

    public int BonusMalus { get; set; }
    public bool Renewable { get; set; }

    [Display(Name = "Modification Date")]
    public int RefundedAmount { get; set; }

    [Required(ErrorMessage = "You have to leave a comment before validating!")]
    public String Comment { get; set; }

    //    public int? IdVehicle { get; set; }

    public virtual Vehicle Vehicles { get; set; }

}
}


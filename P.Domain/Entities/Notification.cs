using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Notification
    {
        [Key]
        public int idNotif { get; set; }
        public int notification { get; set; }
        public DateTime credate { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public virtual User user { get; set; }
    }
}

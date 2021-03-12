using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YCReservations.Models
{
    [Table("Reservations")]
    public class Reservations
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Boolean Status { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }

        public virtual ReservationType ReservationType { get; set; }
    }
}

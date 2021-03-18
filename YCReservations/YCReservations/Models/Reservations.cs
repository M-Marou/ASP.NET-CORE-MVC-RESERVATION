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

        public Boolean? Status { get; set; }

        [Required(ErrorMessage ="There is no user id selected")]
        public string UserId { get; set; }
        public AppUser User { get; set; }

        [Required(ErrorMessage = "Please Select a type of reservation")]
        [Display(Name = "Type")]
        public int ReservationTypeId { set; get; }
        public virtual ReservationType ReservationType { get; set; }
    }
}

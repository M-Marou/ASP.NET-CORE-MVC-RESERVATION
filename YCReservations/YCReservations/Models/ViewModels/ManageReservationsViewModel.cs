using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YCReservations.Models.ViewModels
{
    public class ManageReservationsViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public Boolean? Status { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public AppUser User { get; set; }

        [Display(Name = "Type")]
        public int ReservationTypeId { set; get; }
        public virtual ReservationType ReservationType { get; set; }
    }
}

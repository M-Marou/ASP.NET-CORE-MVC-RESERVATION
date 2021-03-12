using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YCReservations.Models.ViewModels
{
    public class ReservationApplyViewModel
    {
        public int TypeId { get; set; }

        [Required(ErrorMessage = "Please Select a type of reservation")]
        [Display(Name = "Select Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Date :")]
        public DateTime Date { get; set; }
    }
}

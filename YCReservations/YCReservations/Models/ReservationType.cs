using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YCReservations.Models
{
    [Table("ReservationType")]
    public class ReservationType
    {
        [Key]
        public int TypeId { get; set; }

        [Required(ErrorMessage = "Please Select a type of reservation")]
        [Display(Name = "Select Type")]
        public string ResType { get; set; } 

        public int NumberOfPeople { get; set; }

        public ICollection<Reservations> Reservations { get; set; }
    }
}


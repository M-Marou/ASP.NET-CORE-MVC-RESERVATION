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

        public string ResType { get; set; } 

        public int NumberOfPeople { get; set; }

        public virtual ICollection<Reservations> Reservations { get; set; }
    }
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reservations.Data
{
    public class Reservations
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ReservationDate { get; set; }
        public string Status { get; set; }
    }
}

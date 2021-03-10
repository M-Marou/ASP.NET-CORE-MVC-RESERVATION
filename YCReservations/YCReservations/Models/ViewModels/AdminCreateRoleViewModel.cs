using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YCReservations.Models.ViewModels
{
    public class AdminCreateRoleViewModel
    {
        [Required(ErrorMessage = "Please add a role")]
        [Display(Name = "Enter a role name :")]
        public string RoleName { get; set; }
    }
}

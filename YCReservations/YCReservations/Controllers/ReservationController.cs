using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCReservations.Models;
using YCReservations.Models.ViewModels;

namespace YCReservations.Controllers
{
    public class ReservationController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationController(AppDbContext context)
        {
            _context = context;
        }

       [HttpGet]
        public IActionResult Book()
        {
            ViewData["ReservationTypeId"] = new SelectList(_context.ReservationType, "TypeId", "ResType");
            return View();
        }
    }
}

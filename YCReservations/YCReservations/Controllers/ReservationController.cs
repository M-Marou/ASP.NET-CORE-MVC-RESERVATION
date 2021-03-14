using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
    [Authorize(Roles = "Admin, Learner")]
    public class ReservationController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public ReservationController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Book()
        {
            ViewBag.UserId = userManager.GetUserId(HttpContext.User);
            ViewData["ReservationTypeId"] = new SelectList(_context.ReservationType, "TypeId", "ResType");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Book([Bind("Id,Date,Status,UserId,ReservationTypeId")] Reservations Reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction("ManageReservations", "Reservation");
            }
            ViewData["ReservationTypeId"] = new SelectList(_context.ReservationType, "TypeId", "ResType", Reservation.ReservationTypeId);
            return View(Reservation);
        }

        [HttpGet]
        public IActionResult ManageReservations()
        {
            var MyRes = _context.Reservations;
            return View(MyRes);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var reservation = _context.Reservations.Where(r => r.Id == id).FirstOrDefault();
            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
            return RedirectToAction("ManageReservations", "Reservation");
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int id)
        {
            var reservation = _context.Reservations.Where(r => r.Id == id).FirstOrDefault();
            reservation.Status = true;
            if (ModelState.IsValid)
            {
                await _context.SaveChangesAsync();
                return RedirectToAction("ManageReservations", "Reservation");
            }
            return View(reservation);
        }

        [HttpPost]
        public async Task<IActionResult> Declined(int id)
        {
            var reservation = _context.Reservations.Where(r => r.Id == id).FirstOrDefault();
            reservation.Status = false;
            if (ModelState.IsValid)
            {
                await _context.SaveChangesAsync();
                return RedirectToAction("ManageReservations", "Reservation");
            }
            return View(reservation);
        }
    }
}

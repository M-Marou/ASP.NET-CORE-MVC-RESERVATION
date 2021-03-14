using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCReservations.Models;
using YCReservations.Models.ViewModels;

namespace YCReservations.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AppUser> userManager;
        private readonly ILogger<AdminController> logger;

        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, ILogger<AdminController> logger)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.logger = logger;
        }
        [HttpGet]
        public ActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateRole(AdminCreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole()
                {
                    Name = model.RoleName
                };

                IdentityResult result = await this.roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(ListRoles));
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
                if (!(role is null))
                {
                    IdentityResult result = await roleManager.DeleteAsync(role);

                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                return RedirectToAction("ListRoles", "Admin");
        }


        [HttpGet]
        public async Task<ActionResult> Edit(string id)
        {

            if (id is null)
            {
                ViewBag.ErrorMessage = "There is no Role ID Selected";
                return View("NotFound");
            }
            IdentityRole role = await this.roleManager.FindByIdAsync(id);

            if (role is null)
            {
                ViewBag.ErrorMessage = $"The role ID {id} cannot be found !";
                return View("NotFound");
            }

            EditRoleViewModel model = new EditRoleViewModel()
            {
                Id = role.Id,
                RoleName = role.Name,
                Users = new List<string>()
            };


            var userList = await userManager.Users.ToListAsync();

            foreach (AppUser user in userList)
            {
                
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.Email);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(EditRoleViewModel model)
        {

            if (ModelState.IsValid)
            {
                IdentityRole role = await this.roleManager.FindByIdAsync(model.Id);

                if (role is null)
                {
                    ViewBag.ErrorMessage = $"The role ID {model.Id} cannot be found !";
                    return View("NotFound");
                }

                role.Name = model.RoleName;
                IdentityResult result = await roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(ListRoles));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> EditUsersRole(string idRole)
        {
            if (string.IsNullOrEmpty(idRole))
            {
                ViewBag.ErrorMessage = $"The role must exist and not empty in the URL !";
                return View("NotFound");
            }

            IdentityRole role = await this.roleManager.FindByIdAsync(idRole);

            if (role is null)
            {
                ViewBag.ErrorMessage = $"The role ID {idRole} cannot be found !";
                return View("NotFound");
            }

            List<EditUsersRoleViewModel> Models = new List<EditUsersRoleViewModel>();

            var userList = await userManager.Users.ToListAsync();

            foreach (AppUser user in userList)
            {
                EditUsersRoleViewModel model = new EditUsersRoleViewModel()
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    IsSelected = false
                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.IsSelected = true;
                }

                Models.Add(model);
            }

            ViewBag.RoleId = idRole;
            return View(Models);
        }

        [HttpPost]
        public async Task<ActionResult> EditUsersRole(List<EditUsersRoleViewModel> model, string idRole)
        {
            if (string.IsNullOrEmpty(idRole))
            {
                ViewBag.ErrorMessage = $"The role must exist and not empty in the URL !";
                return View("NotFound");
            }

            IdentityRole role = await this.roleManager.FindByIdAsync(idRole);

            if (role is null)
            {
                ViewBag.ErrorMessage = $"The role ID {idRole} cannot be found !";
                return View("NotFound");
            }

            IdentityResult result = null;

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);
                if (await userManager.IsInRoleAsync(user, role.Name) && !model[i].IsSelected)
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else if (!(await userManager.IsInRoleAsync(user, role.Name)) && model[i].IsSelected)
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }

                if (result != null && !result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                    }
                }
            }

            return RedirectToAction(nameof(Edit), new { id = idRole });
        }

        [HttpGet]
        public ActionResult ListUsers()
        {
            var users = userManager.Users.Where(u => u.Email != User.Identity.Name);
            return View(users);
        }

        //[HttpGet]
        //public IActionResult DeleteUser()
        //{
        //    return RedirectToAction("ListUsers");
        //}

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            //if (user is null)
            //{

            //    return View("/NotFound", $"The user Id : {id} cannot be found");
            //}

            var result = await userManager.DeleteAsync(user);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return RedirectToAction("ListUsers", "Admin");
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                AppUser user = await userManager.FindByIdAsync(id);
                if (user != null)
                {
                    EditUsersViewModel model = new EditUsersViewModel()
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        Id = user.Id
                    };
                    return View(model);
                }
            }
            return RedirectToAction("ListUsers", "Admin");
        }


        [HttpPost]
        public async Task<IActionResult> EditUser(EditUsersViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.Email = model.Email;

                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("ListUsers", "Admin");
                    }
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}


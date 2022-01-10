using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MLT.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public UsersController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(string userName)
        {
            if (userName != null)
            {
                await _userManager.CreateAsync(new IdentityUser(userName.Trim()));
            }
            return RedirectToAction("Index");
        }
    }
}


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Webshop.Data;
using MVC_Webshop.ViewModels;

namespace MVC_Webshop.Controllers
{

    public class RolesController : Controller
    {
        readonly RoleManager<IdentityRole> _roleManager;
        readonly UserManager<ApplicationUser> _userManager;
        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            int test = 5;

            return View(_roleManager.Roles);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            role.NormalizedName = role.Name.ToUpper();
            await _roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            await _roleManager.DeleteAsync(role);
            return RedirectToAction("Index");


        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var userToDelete = await _userManager.FindByIdAsync(id);

            if (userToDelete != null)
            {
                await _userManager.DeleteAsync(userToDelete);
            }
            return RedirectToAction("ShowAllUsers");
        }

        public IActionResult AddUserToRole()
        {
            ViewBag.Users = new SelectList(_userManager.Users, "Id", "UserName");
            ViewBag.Roles = new SelectList(_roleManager.Roles, "Name", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUserToRole(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.AddToRoleAsync(user, roleName);
            return RedirectToAction("Index");
        }

        public IActionResult ShowAllUsers()
        {
            return View(_userManager.Users);
        }

        public async Task<IActionResult> ShowUserRoles(string Id)
        {
            ApplicationUserRoleViewModel arvm = new ApplicationUserRoleViewModel();
            var user = await _userManager.FindByIdAsync(Id);

            var assignedRoles = new List<string>(await _userManager.GetRolesAsync(user));
            arvm.UserId = Id;
            arvm.UserName = $"{user.FirstName} {user.LastName}";
            arvm.Roles.AddRange(assignedRoles);

            return View(arvm);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveRoleFromUser(string rolename, string userid)
        {
            var user = await _userManager.FindByIdAsync(userid);
            await _userManager.RemoveFromRoleAsync(user, rolename);

            return RedirectToAction("ShowUserRoles", new { id = userid });
        }

    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Webshop.Data;
using MVC_Webshop.Models;
using MVC_Webshop.ViewModels;
using System.Diagnostics;
using System.Security.Claims;

namespace MVC_Webshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var pvm = new ProductViewModel();

            pvm.listOfProducts = _context.Products
                .Include(c => c.Categories).ToList();

            return View(pvm);
        }

        public IActionResult Details(int id)
        {
            Product? prod = _context.Products.Find(id);
            ProductUserViewModel? puvm = new ProductUserViewModel();
            puvm.Product = prod;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            puvm.User = _userManager.Users.FirstOrDefault(u => u.Id == userId);

            return View(puvm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
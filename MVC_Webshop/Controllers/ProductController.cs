using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Webshop.Data;
using MVC_Webshop.Models;
using MVC_Webshop.ViewModels;
using System.Linq;

namespace MVC_Webshop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        static ProductViewModel pvm = new();
        static ProductCreateViewModel pcvm = new ProductCreateViewModel();

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductController
        public IActionResult Index()
        {
            pvm.listOfProducts = _context.Products
                .Include(c => c.Categories).ToList();

            return View(pvm);
        }

        // GET: ProductController/Details/5
        public IActionResult Details(int id)
        {
            Product? product = _context.Products
                .Include(c => c.Categories)
                .FirstOrDefault(p => p.Id == id);

            return View(product);
        }

        // GET: ProductController/Create
        public IActionResult Create()
        {
            var categories = _context.Categories;

            ViewBag.CategoryList = new SelectList(categories, "Id", "Name");

            return View(pcvm);
        }

        // POST: ProductController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(ProductCreateViewModel product)
        {
            

            ModelState.Remove("Id");
            if(ModelState.IsValid && product.CategoryId != 0)
            {
                var ProductToAdd = new Product()
                {
                    Name = product.Name,
                    Brand = product.Brand,
                    Price = product.Price,
                    ShortDescription = product.ShortDescription,
                    Description = product.Description,
                    Quantity = product.Quantity,
                    //CategoryId = product.CategoryId,
                    
                    ImageUrl = "/img/banana.jpg"
                };

                Category? cat = _context.Categories.Find(product.CategoryId);
                if(cat != null)
                {
                    ProductToAdd.Categories.Add(cat);
                }

                _context.Products.Add(ProductToAdd);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                if (product.CategoryId == 0)
                {
                    ViewBag.CategoryError = "Category is Required";
                }

                var categories = _context.Categories;
                ViewBag.CategoryList = new SelectList(categories, "Id", "Name");

                return View(pcvm);
            }
        }

        // GET: ProductController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

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
        static ProductCreateViewModel pcvm = new ProductCreateViewModel();

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductController
        public IActionResult Index()
        {
            var pvm = new ProductViewModel();

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
        public IActionResult Create(ProductCreateViewModel product, List<string> categoriesMulti)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                var ProductToAdd = new Product()
                {
                    Name = product.Name,
                    Brand = product.Brand,
                    Price = product.Price,
                    ShortDescription = product.ShortDescription,
                    Description = product.Description,
                    Quantity = product.Quantity,

                    ImageUrl = "/img/banana.jpg"
                };

                Category? catToAdd = new Category();
                foreach (var item in categoriesMulti)
                {
                    int castItem = Int32.Parse(item);
                    catToAdd = _context.Categories.FirstOrDefault(c => c.Id == castItem);

                    if (catToAdd != null)
                    {
                        ProductToAdd.Categories.Add(catToAdd);
                    }
                }

                _context.Products.Add(ProductToAdd);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                if (product.categoriesMulti.Count == 0)
                {
                    ViewBag.CategoryError = "Category is Required";
                }

                var categories = _context.Categories;
                ViewBag.CategoryList = new SelectList(categories, "Id", "Name");

                return View(pcvm);
            }
        }

        // GET: ProductController/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Product? product = _context.Products.Find(id);

            Product? product = _context.Products
                .Include(c => c.Categories)
                .FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                pcvm.Name = product.Name;
                pcvm.Brand = product.Brand;
                pcvm.Price = product.Price;
                pcvm.ShortDescription = product.ShortDescription;
                //pcvm.ImageUrl = product.ImageUrl
                pcvm.Quantity = product.Quantity;
            }

            var categories = _context.Categories;
            string selectedVal = "1";
            ViewBag.CategoryList = new MultiSelectList(categories, "Id", "Name", selectedVal);

            return View(pcvm);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            if (true)
            {
                return RedirectToAction(nameof(Index));

            }
            else
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
            var prodToRemove = _context.Products.Find(id);

            if (prodToRemove != null)
            {
                _context.Products.Remove(prodToRemove);
            }

            return RedirectToAction(nameof(Index));
            
        }
    }
}

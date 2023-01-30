using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Webshop.Data;
using MVC_Webshop.Models;
using MVC_Webshop.ViewModels;
using System.Linq;

using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Runtime.CompilerServices;

namespace MVC_Webshop.Controllers
{
    public class ProductController : Controller
    {

        //HELPER FUNCTIONS
        string UploadedFile(ProductCreateViewModel product)
        {
            string? uniqueFileName = null;

            if (product.ImageUp != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imagesProduct");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + product.ImageUp.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    product.ImageUp.CopyTo(fileStream);
                }
            }

            return "/imagesProduct/" + uniqueFileName;
        }

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductController(ApplicationDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            webHostEnvironment = webHost;
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
            ProductCreateViewModel pcvm = new ProductCreateViewModel();
            var categories = _context.Categories;

            ViewBag.CategoryList = new SelectList(categories, "Id", "Name");

            return View(pcvm);
        }

        // POST: ProductController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(ProductCreateViewModel product, List<string> categoriesMulti)
        {
            ProductCreateViewModel pcvm = new ProductCreateViewModel();

            string uniqueFileName = UploadedFile(product);
            product.ImageUrl = uniqueFileName;

            ModelState.Remove("Id");
            ModelState.Remove("ImageUrl");
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
                    ImageUrl = uniqueFileName
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
            ProductCreateViewModel pcvm = new ProductCreateViewModel();
            Product? product = _context.Products
                .Include(c => c.Categories)
                .FirstOrDefault(p => p.Id == id);



            List<int>? categoriesIds = new();
            foreach (var productNum in product.Categories)
            {
                categoriesIds.Add(productNum.Id);
            }

            if (product != null)
            {
                pcvm.Name = product.Name;
                pcvm.Brand = product.Brand;
                pcvm.Price = product.Price;
                pcvm.ShortDescription = product.ShortDescription;
                pcvm.Description = product.Description;
                //pcvm.ImageUrl = product.ImageUrl;
                pcvm.Quantity = product.Quantity;
                pcvm.CategoryIds = categoriesIds;

                var categories = _context.Categories;

                ViewBag.CategoryList = new MultiSelectList(categories, "Id", "Name");
                ViewBag.Image = product.ImageUrl;
            }



            return View(pcvm);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProductCreateViewModel prod, List<string> CategoryIds)
        {
            Product? productToEdit = _context.Products.Find(id);


            ModelState.Remove("Id");
            ModelState.Remove("ImageUrl");
            ModelState.Remove("ImageUp");
            if (productToEdit != null && ModelState.IsValid)
            {
                productToEdit.Name = prod.Name;
                productToEdit.Brand = prod.Brand;
                productToEdit.Price = prod.Price;
                productToEdit.ShortDescription = prod.ShortDescription;
                productToEdit.Description = prod.Description;
                productToEdit.Quantity = prod.Quantity;
                productToEdit.ImageUrl = productToEdit.ImageUrl;

                var catToDelete = _context.Products.Include(c => c.Categories)
                                        .FirstOrDefault(p => p.Id == id);

                List<Category> temp = new List<Category>();

                foreach (var item in catToDelete.Categories)
                {
                    temp.Add(item);
                }

                foreach (var cat in temp)
                {
                    catToDelete.Categories.Remove(cat);
                }

                Category? catToAdd = new Category();
                foreach (var item in CategoryIds)
                {
                    int castItem = Int32.Parse(item);
                    catToAdd = _context.Categories.FirstOrDefault(c => c.Id == castItem);

                    if (catToAdd != null)
                    {
                        productToEdit.Categories.Add(catToAdd);
                    }

                }

                _context.Products.Update(productToEdit);
                _context.SaveChanges();

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
            var prodToRemove = _context.Products.Find(id);

            if (prodToRemove != null)
            {
                _context.Products.Remove(prodToRemove);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));

            //return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            var prodToRemove = _context.Products.Find(id);

            if (prodToRemove != null)
            {
                _context.Products.Remove(prodToRemove);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));

        }

    }
}
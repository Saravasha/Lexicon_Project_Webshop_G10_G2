using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Webshop.Data;
using MVC_Webshop.Models;
using MVC_Webshop.ViewModels;

namespace MVC_Webshop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        static CategoryViewModel cvm = new();
        static CategoryCreateViewModel ccvm = new();

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            cvm.listOfCategories = _context.Categories.ToList();

            return View(cvm);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View(ccvm);
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryCreateViewModel category)
        {

            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                var CatToAdd = new Category()
                {
                    Name = category.Name
                };

                _context.Categories.Add(CatToAdd);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(ccvm);
            }

        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var ccvm = new CategoryCreateViewModel();
            var category = _context.Categories.Find(id);
            ccvm.Name = category.Name;
            return View(ccvm);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CategoryCreateViewModel collection)
        {
            var categoryToEdit = _context.Categories.Find(id);

            if(ModelState.IsValid)
            {
                categoryToEdit.Name = collection.Name;

                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(collection);
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            //Category? catRemove = _context.Categories.Find(id);
            Category? categoryToDelete = _context.Categories.Include(x => x.Products).FirstOrDefault(y => y.Id == id);

            if(categoryToDelete != null && categoryToDelete.Products.Count != 0)
            {
                ViewBag.IsInUse = "isinuse";
                cvm.listOfCategories = _context.Categories.ToList();
                return View("Index", cvm);
            }
            else
            {
                _context.Categories.Remove(categoryToDelete);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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

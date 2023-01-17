using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                //ViewBag.CategoryError

                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
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

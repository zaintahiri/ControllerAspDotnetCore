using ControllerAspDotnetCore.Models;
using ControllerAspDotnetCore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ControllerAspDotnetCore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories =CategoryRepository.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            //if (id.HasValue)
            //    return new ContentResult { Content = id.ToString() };
            //else
            //    return new ContentResult { Content = "Null value found for ID" };
            //var categtory = new Category { Id = id.HasValue ? id.Value : 0 };

            var category = CategoryRepository.GetCategory(id.Value);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid) 
            {
                CategoryRepository.UpdateCategory(category.Id, category);
                return RedirectToAction(nameof(Index));

            }
            return View(category);
            
        }
    }
}

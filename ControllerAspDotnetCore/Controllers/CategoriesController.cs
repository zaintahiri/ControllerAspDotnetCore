﻿using ControllerAspDotnetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerAspDotnetCore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(int? id)
        {
            //if (id.HasValue)
            //    return new ContentResult { Content = id.ToString() };
            //else
            //    return new ContentResult { Content = "Null value found for ID" };
            var categtory = new Category { Id = id.HasValue ? id.Value : 0 };
            return View(categtory);
        }
    }
}

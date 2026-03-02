using crud_mvc_aspnet_core.Models;
using crud_mvc_aspnet_core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_mvc_aspnet_core.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Message = "Ingrese los datos de la categoría";

            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.CreateCategory(category);

                TempData["AlertMessage"] = "Se ha agregado la categoría.";
                TempData["AlertStyle"] = AlertConstants.SUCCESS;

                return RedirectToAction("List");
            }

            return View();
        }

        public IActionResult Delete(int id)
        {
            TempData["AlertMessage"] = "Se ha eliminado la categoría '" + _categoryService.GetCategory(id).Name + "'";
            TempData["AlertStyle"] = AlertConstants.SUCCESS;

            _categoryService.DeleteCategory(id);

            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            ViewBag.Message = "Lista de categorias existentes.";
            ViewBag.TooltipText = "No se pueden borrar categorías con artículos relacionados.";

            return View(_categoryService.GetCategories());
        }
    }
}

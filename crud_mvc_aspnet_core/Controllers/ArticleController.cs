using crud_mvc_aspnet_core.Models;
using crud_mvc_aspnet_core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_mvc_aspnet_core.Controllers
{
    public class ArticleController : BaseController
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;

        public ArticleController(IArticleService articleService, ICategoryService categoryService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Message = "Ingrese los datos del artículo";
            ViewBag.Categories = _categoryService.GetCategories();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Article article)
        {
            article.Category = _categoryService.GetCategory(article.CategoryId);

            if (ModelState.IsValid)
            {
                _articleService.CreateArticle(article);

                TempData["AlertMessage"] = "Se ha agregado el artículo.";
                TempData["AlertStyle"] = AlertConstants.SUCCESS;

                return RedirectToAction("List");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Message = "Datos del artículo";
            ViewBag.Categories = _categoryService.GetCategories();

            return View(_articleService.GetArticle(id));
        }

        [HttpPost]
        public IActionResult Edit(Article article)
        {
            article.Category = _categoryService.GetCategory(article.CategoryId);

            if (ModelState.IsValid)
            {
                _articleService.UpdateArticle(article);

                TempData["AlertMessage"] = "Se ha actualizado el artículo";
                TempData["AlertStyle"] = AlertConstants.SUCCESS;

                return RedirectToAction("List");
            }

            return View();
        }

        public IActionResult Delete(int id)
        {
            TempData["AlertMessage"] = "Se ha eliminado el artículo '" + _articleService.GetArticle(id).Name + "'";
            TempData["AlertStyle"] = AlertConstants.SUCCESS;

            _articleService.DeleteArticle(id);

            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            ViewBag.Message = "Lista de artículos existentes";

            return View(_articleService.GetArticles());
        }
    }
}

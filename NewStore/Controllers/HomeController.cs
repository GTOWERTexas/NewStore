using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NewStore.Controllers
{
    public class HomeController: Controller
    {
        // подключение к репозиторию с помощью внедрения зависимостей
        private IStoreRepository repository;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        
        // первичное представление с поисковиком
        public IActionResult Index(string searchTerm)
        {
            ViewData["searchTerm"] = searchTerm;
            return View((!string.IsNullOrEmpty(searchTerm)) ? repository.Products.Where(c => c.Name.ToLower().Contains(searchTerm.ToLower())).ToList() : repository.Products);
        }
        public IEnumerable<Product> Products { get; set; }
        // отображение мужских товаров
        public IActionResult ManList(long? id)
        {
            if (id == 0)
            {
                Products = repository.Products.Where(p => p.IsMan == true);

                return View(Products);
            }
            else
            {
                Products = repository.Products.Where(p => p.IsMan == true && p.CategoryId == id);
                return View(Products);
            }
        }
        // отображение женских товаров товаров
        public IActionResult WomanList(long? id)
        {
            if (id == 0)
            {
                Products = repository.Products.Where(p => p.IsMan == false);

                return View(Products);
            }
            else
            {
                Products = repository.Products.Where(p => p.IsMan == false && p.CategoryId == id);
                return View(Products);
            }
        }
        
        // подробнее о товаре
        public async Task<IActionResult> Details(long id)
        {
            Product p = await repository.Products.Include(p => p.Category).FirstOrDefaultAsync(p=>p.ProductId == id);

            return View(p);
        }


    }
}

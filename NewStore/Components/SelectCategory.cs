using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewStore.Models;
using Microsoft.AspNetCore.Mvc;


namespace NewStore.Components
{
    public class SelectCategory : ViewComponent
    {
        IStoreRepository _repository;
        public SelectCategory(IStoreRepository repository)
        {
            _repository = repository;
        }
        IEnumerable<Category> Categories => _repository.Categories.Where(c=>c.IsClothes == true);
        public IViewComponentResult Invoke()
        {
           return View(Categories);
        }
    }
}

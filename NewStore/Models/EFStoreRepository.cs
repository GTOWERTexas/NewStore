using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace NewStore.Models
{   // реализация интерфейса хранилища товаров
    public class EFStoreRepository:IStoreRepository
    {
        // получения доступа к контексту
        private DataContext context;
        public EFStoreRepository(DataContext ctx)
        {
            context = ctx;
        }
        // сохраняем объекты из бд в свойствах моделей
        public IQueryable<Product> Products => context.Products;
        public IQueryable<Category> Categories => context.Categories;
        
        // альтернативный CRUD, который в приложение не используется(используется Blazor)
        public void CreateProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
        }
        public void DeleteProduct(Product p)
        {
            context.Remove(p);
            context.SaveChanges();
        }
        public void SaveProduct(Product p)
        {
            context.SaveChanges();
        }

        public void CreateCategory(Category c)
        {
            context.Add(c);
            context.SaveChanges();
        }
        public void DeleteCategory(Category c)
        {
            context.Remove(c);
            context.SaveChanges();
        }
        public void SaveCategory(Category c)
        {
            context.SaveChanges();
        }

   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewStore.Models
{
    public interface IStoreRepository
    {   // получение последовательности объектов Product
        IQueryable<Product> Products { get; }
        // CRUD 
        void CreateProduct(Product p);
        void DeleteProduct(Product p);
        void SaveProduct(Product p);
        
         // получение последовательности объектов Category
        IQueryable<Category> Categories { get; }
        void CreateCategory(Category c);
        void DeleteCategory(Category c);
        void SaveCategory(Category c);

    }
}

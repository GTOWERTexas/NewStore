using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewStore.Models
{   // класс категорий 
    public class Category
    {
        public string Name { get; set; } // имя

        public long Id { get; set; } // идентификатор

        public IEnumerable<Product> Products { get; set; } // отношение один ко многим (категория - продукты)

        public bool IsClothes { get; set; } = false; 
    }
}

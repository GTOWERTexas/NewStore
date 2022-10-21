using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewStore.Models
{
    public class Category
    {
        public string Name { get; set; }

        public long Id { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public bool IsClothes { get; set; } = false;
    }
}

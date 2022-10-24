using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewStore.Models
{   // модель товара
    public class Product
    {
        public long ProductId { get; set; }

        public string Name { get; set; }

        [Column(TypeName ="decimal(8,2)")]
        public decimal Price { get; set; }

        public string Size { get; set; }

        public string Composition { get; set; }

        public string Country { get; set; }

        //man = true
        public bool IsMan { get; set; } = false;

        public long CategoryId { get; set; } // отношение один к одному

        public Category Category { get; set; }
    }
}

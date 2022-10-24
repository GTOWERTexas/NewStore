using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewStore.Models
{   // класс контекста базы данных - посредник между приложением и БД
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts):base(opts)
        {

        }
        // эти свойтва предоставляют доступ к объектам в базе данных
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}

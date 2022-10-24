using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
namespace NewStore.Models
{   // реализация интерфейса хранилища
    public class EFOrderRepository : IOrderRepository
    {
        // получене контекста 
        private DataContext context;
        public EFOrderRepository(DataContext ctx)
        {
            context = ctx;
        }
        // присваивание свойству Orders объектов Order из бд со связанными данными
        public IQueryable<Order> Orders => context.Orders.Include(o => o.Lines).ThenInclude(l => l.Product); 
        // добавление ордера в бд
        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderId == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }


    }
}

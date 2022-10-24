using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewStore.Models
{   
    public interface IOrderRepository
    {
        // получение последовательности объектов Order
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}

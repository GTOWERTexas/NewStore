using Microsoft.AspNetCore.Mvc;
using NewStore.Models;
using System.Linq;

namespace NewStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        // внедрение зависимостей
        private Cart cart;
        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }
        // заполнение формы ордера
        public ViewResult Checkout() => View(new Order());
        
        // сохранение ордера в базе данных
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order); // сохранение ордера
                cart.Clear(); // очистка корзины
                return RedirectToPage("/Completed", new { order = order.OrderId });
            }
            else
            {
                return View();
            }
        }
    }
}

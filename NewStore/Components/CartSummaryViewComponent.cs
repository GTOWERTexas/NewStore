using Microsoft.AspNetCore.Mvc;
using NewStore.Models;

namespace NewStore.Components
{
    // создание компонента представления - задействует службу так, чтобы получать объект Cart как аргумент конструктора
    // компонент создает якорный элемент, который отображает состояние корзины покупателя
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        // результат 
        public IViewComponentResult Invoke()
        {
            return View(cart);  
        }
    }
}

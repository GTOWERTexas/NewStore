using System.Collections.Generic;
using System.Linq;


namespace NewStore.Models
{ 
    // реализация средства корзины    
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(Product product, int quantity) // добавить продукт в колличестве n
        {
            CartLine line = Lines.Where(p=>p.Product.ProductId == product.ProductId).FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine { Product = product, Quantity = quantity }) ;
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(Product product) => Lines.RemoveAll(l=>l.Product.ProductId == product.ProductId); // удалить товар с корзины
        public decimal ComputeTotalValue() => Lines.Sum(l=>l.Product.Price * l.Quantity); // сумма заказа
        public virtual void Clear() => Lines.Clear();
    }

    public class CartLine // товар, выбранный пользователем
    {
        public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

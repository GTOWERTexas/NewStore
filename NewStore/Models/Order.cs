using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net.Mail;
using System.Threading.Tasks;

namespace NewStore.Models
{   // Модель формы заказа
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        
        [Required(ErrorMessage = "Please enter a name")]
        public string NameUser { get; set; }
        public string PhoneUser { get; set; }

        public string EmailAddres { get; set; }
        [Required(ErrorMessage = "Please enter the addres City")]
        public string City { get; set; }
        //  public bool Pickup { get; set; } 

        public bool Courier { get; set; }
        public string Comment { get; set; }
        public string Line1  { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [BindNever]
        public bool Shipped { get; set; }  
    }
 

}

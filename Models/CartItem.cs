using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Online_Shop.Models
{
    public class CartItem
    {
        [Key]
        public int CartId { get; set; }
        public int ProductId { get; set; }
        //public virtual Product[] Product { get; set; }
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public CartState State { get; set; }
        

    }
}

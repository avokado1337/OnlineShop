using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public CartState State { get; set; }
        public List<CartItem> Items { get; set; }
    }
}

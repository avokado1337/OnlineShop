using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<CartItem> OrderItems { get; set; }
        public List<OrderHistory> Changes{ get; set; }
        public CartState State { get; set; }
        public string Adress { get; set; }
        public string CardNumber { get; set; }
        public DateTime OrderTime { get; set; }
    }
}

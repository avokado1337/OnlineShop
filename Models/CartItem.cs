namespace Online_Shop.Models
{
    public class CartItem
    {
        public int Cartid { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public CartState State { get; set; }
        

    }
}

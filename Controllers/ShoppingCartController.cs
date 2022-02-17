using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IEnumerable<CartItem> AddToCart(int id, int qnt)
        {
            var product = _context.Products.First(p => p.ProductId.Equals(id));
            _context.CartItems.Add(new CartItem
            {
                //Quantity = qnt,
                //ProductId = id,
                //List<Product> product = new List<Product>
                //Products = product,
                //State = CartState.Creating
            });
            _context.SaveChanges();
            return _context.CartItems.ToList();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet]
        public IEnumerable<CartItem> Get(int cartId)
        {
            var cart = _context.Carts.Include(x => x.Items).First(x => x.Id == cartId);
            var res = _context.CartItems.Where(x => x.CartId == cart.Id).Select(s => s.Product.ProductName).ToList();
            return res;
        }

        [HttpPost("carts/{cartId}")]
        public ActionResult<Cart> AddToCart(int cartId, int productId, int quantity)
        {
            var product = _context.Products.First(x => x.ProductId == productId);
            var cart = _context.Carts.Include(x => x.Items).First(x => x.Id == cartId);
            cart.Items.Add(new CartItem
            {
                Product = product,
                Quantity = quantity,
                CartId = cartId
            });

            _context.SaveChanges();
            return cart;
        }

        [HttpPut("carts/{cartId}")]
        public ActionResult<Cart> AddToExistingCart(int cartId, int productId, int quantity)
        {
            var product = _context.Products.First(x => x.ProductId == productId);
            var cart = _context.Carts.Include(x => x.Items).First(x => x.Id == cartId);
            cart.Items.Add(new CartItem
            {
                Product = product,
                Quantity = quantity,
            });

            _context.SaveChanges();
            return cart;
        }
    }
}

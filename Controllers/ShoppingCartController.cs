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

        //Показать всю корзину
        [HttpGet]
        public async Task<ActionResult<Cart>> GetAsync(int cartId)
        {
            var cart = await _context.Carts.Include(x => x.Items).ThenInclude(e => e.Product).FirstAsync(x => x.Id == cartId);
            return cart;
        }


        //Добавить товар в корзину
        [HttpPut("carts/{cartId}")]
        public async Task<ActionResult<Cart>> AddToExistingCartAsync(int cartId, int productId, int quantity)
        {
            var product = await _context.Products.FirstAsync(x => x.ProductId == productId);
            var cart =  await _context.Carts.Include(x => x.Items).ThenInclude(i => i.Product).FirstAsync(x => x.Id == cartId);
            cart.Items.Add(new CartItem
            {
                Product = product,
                Quantity = quantity,
            });

            await _context.SaveChangesAsync();
            return cart;
        }

        //Удалить товар из корзины
        [HttpDelete("carts/{cartId}/items/{itemId}")]
        public async Task<ActionResult<Cart>> DeleteItemFromCartAsync(int cartId, int itemId)
        {
            var cartItem = await _context.CartItems.FirstAsync(x => x.Id == itemId);

            var cart = await _context.Carts.Include(x => x.Items).ThenInclude(i => i.Product).FirstAsync(x => x.Id == cartId);

            cart.Items.Remove(cartItem);

            await _context.SaveChangesAsync();

            return cart;

        }

        [HttpDelete("carts/{cartId}")]
        public async Task<ActionResult<Cart>> DeleteAllItemsAsync(int cartId)
        {
            var cart = await _context.Carts.Include(x => x.Items).ThenInclude(i => i.Product).FirstAsync(x => x.Id == cartId);

            cart.Items.Clear();

            await _context.SaveChangesAsync();

            return cart;
        }

    }
}

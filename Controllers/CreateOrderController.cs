using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shop.Data;
using Online_Shop.Models;
using Online_Shop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateOrderController
    {
        private readonly ApplicationDbContext _context;

        public CreateOrderController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrdersAsync()
        {
            var orders = await _context.Orders.Include(x => x.OrderItems).ThenInclude(x => x.Product).ToListAsync();

            return orders;
        }

        [HttpPost]
        public async Task<ActionResult<List<Order>>> CreateOrder(int cartId, string adress, string cardNumber)
        {
            var cartItems = await _context.CartItems.Where(x => x.CartId == cartId).Include(x => x.Product).ToListAsync();
            var orders = await _context.Orders.Include(x => x.OrderItems).ThenInclude(x => x.Product).ToListAsync();
            await _context.Orders.AddAsync(new Order
            {
                OrderItems = cartItems,
                State = CartState.Paid,
                Adress = adress,
                CardNumber = cardNumber,
                OrderTime = DateTime.Now
            });

            //var cart = await _context.Carts.FirstAsync(x => x.Id == cartId);
            //cart.Items.Clear();

            await _context.SaveChangesAsync();

            return orders;

        }



    }
}

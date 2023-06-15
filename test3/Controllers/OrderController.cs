using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using test3.Areas.Identity.Data;
using test3.Models;
using test3.Areas.Identity.Data.Cart;
using System.Security.Claims;

namespace test3.Controllers
{
    // [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly test3IdentityDbContext _db;
        public OrderController(ShoppingCart shoppingCart,test3IdentityDbContext db )
        {
            _shoppingCart = shoppingCart;
            _db = db;
        }
        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress
            };
            await _db.Orders.AddAsync(order);
            await _db.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    MovieId = item.Movie.Id,
                    OrderId = order.Id,
                    Price = item.Movie.Price
                };
                await _db.orderItems.AddAsync(orderItem);
            }
            await _db.SaveChangesAsync();
        }
    
        public async Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userid)
        {
            var orders = await _db.Orders.Include(n => n.OrderItems)
            .ThenInclude(n => n.Movie).Where(n => n.UserId == userid).ToListAsync();

            // if(userRole != "Admin")
            // {
            //     orders = orders.Where(n => n.UserId == userId).ToList();
            // }

            return orders;
        }
        public async Task<IActionResult> Index()
        {
            string userId = "";
            // string userRole = "";

            var orders = await GetOrdersByUserIdAndRoleAsync(userId);
            return View(orders);
        }
        public async Task<IActionResult> ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartVM(){
                ShoppingCart = _shoppingCart ,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(response);
        }
        
        public async Task<RedirectToActionResult> AddItemToShoppingCart(int id){
            var item = await _db.Movies
                .Include(c => c.cinema)
                .Include(p => p.producer)
                .Include(am => am.actor_Movies).ThenInclude(a => a.actor)
                .FirstOrDefaultAsync(n => n.Id == id);
            if(item != null){
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));

        }
        
        
        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _db.Movies
                .Include(c => c.cinema)
                .Include(p => p.producer)
                .Include(am => am.actor_Movies).ThenInclude(a => a.actor)
                .FirstOrDefaultAsync(n => n.Id == id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = "";
            string userEmailAddress = "";

            // await StoreOrderAsync(items, userId, userEmailAddress);
            await _shoppingCart.ClearShoppingCartAsync();

            return View("OrderCompleted");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
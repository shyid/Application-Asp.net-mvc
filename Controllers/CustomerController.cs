using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ticket;
using ticket.Models;
using System.Net.Http;
// using System.Web.Http;
using ticket.Areas.Identity.Data;
namespace ticket.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _db;
        public  CustomerController(AppDbContext db){
            _db = db;
        }

        // for tabel list as table custmer
        
        public IActionResult Index(){
            IEnumerable<Customer> objectCustomerlist = _db.Customer.Include(c=>c.MemberShipTypeForCust).ToList();
            // var customers = _context.Customer.Include(c=>c.MemberShipTypeForCust).ToList();
            return View(objectCustomerlist);
        }
        // [HttpDelete]
        // public void DeleteCustomer(int id){
        //     var customerIN= _db.Customer.SingleOrDefaultAsync(c=>c.Id == id);
        //     _db.Customer.Remove(customerIN);

        // }
       // Get
        public ActionResult Delete(int? id){
            if(id == null || id==0) return NotFound();
            var movieDb = _db.Movie.Find(id);
            if(movieDb == null) return NotFound();
            return View(movieDb);
        }
        [HttpPost]
        public ActionResult Delete(Movie obj){
            if(ModelState.IsValid){
                _db.Movie.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        
        // Get api/customer
        // public IEnumerable<Customer> GetCustomers(){
        //     return _db.Customer.ToList();
        // }
        // // Get api/customer/id
        // public Customer GetCustomer(int id){
        //     var viewCustomer = _db.Customer.SingleOrDefault(c=> c.Id == id);
        //     if(viewCustomer == null) {
        //         throw new HttpResponseException(HttpStatusCode.NotFound);
        //     }
        //     return viewCustomer;
        // }
      

    }
}
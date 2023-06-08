using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using test3.Areas.Identity.Data;

namespace test3.Controllers
{
    [Route("[controller]")]
    public class ActorController : Controller
    {
        private readonly test3IdentityDbContext _context;

        public ActorController(test3IdentityDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var allActors =  _context.Actors.ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
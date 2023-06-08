using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test3.Models;
using test3.Areas.Identity.Data;

namespace test3.Controllers
{
    public class MovieController :Controller 
    {
        private readonly test3IdentityDbContext _db;
        public  MovieController(test3IdentityDbContext db){
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _db.Movies.Include(a=>a.cinema).ToListAsync();
            return View(allMovies);
        }

        // Get
        public ActionResult Random(){
            var movie = new Movie(){Name ="sherk!"};
            return View(movie);
        }
       
       
    }
}
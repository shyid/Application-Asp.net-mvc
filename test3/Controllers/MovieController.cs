using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test3.Models;
using test3.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public async Task<IActionResult> Filter(string searchString) //searchString is name box search in file _loginpartial.html
        {
            var allMovies = await _db.Movies.Include(a=>a.cinema).ToListAsync();
            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) 
                || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                // var filteredResultNew = allMovies.Where(n => 
                // string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) ||
                // string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResult);
            }

            return View("Index",allMovies);
        }
        // Get
        // Get:Movie/Create
        public async Task<IActionResult> Create()
        {
            var response = new NewMovieDropdownsVM(){
            Actors = await _db.Actors.OrderBy(n=>n.FullName).ToListAsync(),
            Producers = await _db.Producers.OrderBy(n=>n.FullName).ToListAsync(),
            Cinemas = await _db.Cinemas.OrderBy(n=>n.FullName).ToListAsync()
            };

            ViewBag.CinemaViewBag = new SelectList(response.Cinemas , "Id" ,"FullName");
            ViewBag.ProducerViewBag = new SelectList(response.Producers , "Id" ,"FullName");
            ViewBag.ActorViewBag = new SelectList(response.Actors , "Id" ,"FullName");

            return View();
        }
        [HttpPost]
        // post:Movie/Create
        public async Task<IActionResult> Create(NewMovieVM obj)
        {
            if (!ModelState.IsValid)
            {
                var response = new NewMovieDropdownsVM(){
                Actors = await _db.Actors.OrderBy(n=>n.FullName).ToListAsync(),
                Producers = await _db.Producers.OrderBy(n=>n.FullName).ToListAsync(),
                Cinemas = await _db.Cinemas.OrderBy(n=>n.FullName).ToListAsync()
                };

                ViewBag.CinemaViewBag = new SelectList(response.Cinemas , "Id" ,"FullName");
                ViewBag.ProducerViewBag = new SelectList(response.Producers , "Id" ,"FullName");
                ViewBag.ActorViewBag = new SelectList(response.Actors , "Id" ,"FullName");
                return View(obj);
            }
            var newMovie = new Movie(){
                Name = obj.Name,
                Description = obj.Description,
                Price = obj.Price,
                ImageURL = obj.ImageURL,
                StartDate = obj.StartDate,
                EndDate = obj.EndDate,
                MovieCategory =obj.MovieCategory,
                producerId = obj.ProducerId,
                CinemaId =obj.CinemaId
            };
            await  _db.Movies.AddAsync(newMovie);
            await _db.SaveChangesAsync();
            // Relationship
            foreach (var item in obj.ActorId)
            {
                var newActorMovie = new  Actor_Movie(){
                    MovieId = newMovie.Id,
                    ActorId = item
                };
                await  _db.Actors_Movies.AddAsync(newActorMovie);
            }
            
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        // Get:Movie/Edit/id
        public IActionResult Details(int? id)
        {
            if(id == null || id==0) return NotFound();
            var ViewMovie = _db.Movies.Include(c=>c.cinema).
            Include(p=>p.producer)
            .Include(am=>am.actor_Movies).ThenInclude(a=>a.actor)
            .ToList().FirstOrDefault(d=>d.Id == id);
            if(ViewMovie == null) return NotFound();
            // IEnumerable<Movie> viewMovies = _db.Movies.ToList();
            return View(ViewMovie);
        }

        // Get:Movie/Edit/id
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null || id==0) return NotFound();
            var ViewMovie = _db.Movies.Include(c=>c.cinema).
            Include(p=>p.producer)
            .Include(am=>am.actor_Movies).ThenInclude(a=>a.actor)
            .ToList().FirstOrDefault(d=>d.Id == id);
            if(ViewMovie == null) return NotFound();
            var newMovie = new NewMovieVM(){
                Id = ViewMovie.Id,
                Name = ViewMovie.Name,
                Description = ViewMovie.Description,
                Price = ViewMovie.Price,
                ImageURL = ViewMovie.ImageURL,
                StartDate = ViewMovie.StartDate,
                EndDate = ViewMovie.EndDate,
                MovieCategory =ViewMovie.MovieCategory,
                ProducerId = ViewMovie.producerId,
                CinemaId =ViewMovie.CinemaId,
                ActorId = ViewMovie.actor_Movies.Select(Am=>Am.ActorId).ToList()
            };
            var response = new NewMovieDropdownsVM(){
            Actors = await _db.Actors.OrderBy(n=>n.FullName).ToListAsync(),
            Producers = await _db.Producers.OrderBy(n=>n.FullName).ToListAsync(),
            Cinemas = await _db.Cinemas.OrderBy(n=>n.FullName).ToListAsync()
            };

            ViewBag.CinemaViewBag = new SelectList(response.Cinemas , "Id" ,"FullName");
            ViewBag.ProducerViewBag = new SelectList(response.Producers , "Id" ,"FullName");
            ViewBag.ActorViewBag = new SelectList(response.Actors , "Id" ,"FullName");

            return View(newMovie);
        }
        [HttpPost]
        // post:Movie/Edit
        public async Task<IActionResult> Edit(int? id,NewMovieVM obj)
        {
            if(id == null || id==0) return NotFound();
            var ViewMovie = _db.Movies.Include(c=>c.cinema).
            Include(p=>p.producer)
            .Include(am=>am.actor_Movies).ThenInclude(a=>a.actor)
            .ToList().FirstOrDefault(d=>d.Id == id);
            if(ViewMovie == null) return NotFound();
            if (!ModelState.IsValid)
            {
                var response = new NewMovieDropdownsVM(){
                Actors = await _db.Actors.OrderBy(n=>n.FullName).ToListAsync(),
                Producers = await _db.Producers.OrderBy(n=>n.FullName).ToListAsync(),
                Cinemas = await _db.Cinemas.OrderBy(n=>n.FullName).ToListAsync()
                };

                ViewBag.CinemaViewBag = new SelectList(response.Cinemas , "Id" ,"FullName");
                ViewBag.ProducerViewBag = new SelectList(response.Producers , "Id" ,"FullName");
                ViewBag.ActorViewBag = new SelectList(response.Actors , "Id" ,"FullName");
                return View(obj);
            }
            
            ViewMovie.Name = obj.Name;
            ViewMovie.Description = obj.Description;
            ViewMovie.Price = obj.Price;
            ViewMovie.ImageURL = obj.ImageURL;
            ViewMovie.StartDate = obj.StartDate;
            ViewMovie.EndDate = obj.EndDate;
            ViewMovie.MovieCategory =obj.MovieCategory;
            ViewMovie.producerId = obj.ProducerId;
            ViewMovie.CinemaId =obj.CinemaId;
            
            await _db.SaveChangesAsync();

            var existActors = _db.Actors_Movies.Where(n=>n.MovieId == obj.Id).ToList();
            _db.Actors_Movies.RemoveRange(existActors);
            await _db.SaveChangesAsync();
            // Relationship
            foreach (var item in obj.ActorId)
            {
                var newActorMovie = new  Actor_Movie(){
                    MovieId = obj.Id,
                    ActorId = item
                };
                await  _db.Actors_Movies.AddAsync(newActorMovie);
            }
            
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        // Get:Movie/Delete/id
        // public IActionResult Delete(int? id)
        // {
        //     if(id == null || id==0) return NotFound();
        //     var ViewMovie = _db.Movies.Find(id);
        //     if(ViewMovie == null) return NotFound();
        //     // IEnumerable<Movie> viewMovies = _db.Movies.ToList();
        //     return View(ViewMovie);
        // }
        // [HttpPost]
        // // post:Movie/Delete/id
        // public async Task<IActionResult> DeletePost(int? id)
        // {
        //     if(id == null || id==0) return NotFound();
        //     var ViewMovie = _db.Movies.Find(id);
        //     if(ViewMovie == null) return NotFound();
        //     _db.Remove(ViewMovie);
        //     await _db.SaveChangesAsync();
        //     return RedirectToAction("Index");
        // }
       
       
    }
}
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ticket.Models;
using ticket.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;

namespace ticket.Controllers
{
    public class MovieController :Controller 
    {
        private readonly AppDbContext _db;
        public  MovieController(AppDbContext db){
            _db = db;
        }
        // Get
        public ActionResult Random(){
            var movie = new Movie(){Name ="sherk!"};
            return View(movie);
        }
        // route defult
        // public ActionResult Edit(int Id){
            
        //     return Content("ID "+ Id);
        // }
        // route make
        // [Route("Movie/released/{year}/{month:regex(//d{4})}")]
        // public ActionResult ByReleaseYear(int year , int month){
        //     return Content(year + "/"+ month);
        // }
        // GEt for table movie 
        public ActionResult Details(int id){
            var tableMovie = new  List<Movie>{
               new Movie(){Id=1 ,Name ="one Movie"},
               new Movie(){Id=2 ,Name ="two MOvie"}
            };
            var viewodel = new MovieViewModel(){
                MoviesList = tableMovie
            };
            
            return View(viewodel);
        }
        // // post show table movie with database
        // [HttpPost]
        //Get
        public ActionResult Index(){
            IEnumerable<Movie> viewmovieModel = _db.Movie;
            
            if(User.IsInRole("Admin"))
                return View("List",viewmovieModel);

            return View("onlyReadList",viewmovieModel);
        }
        // btn CreateMovie
        // Get
        [Authorize(Roles = "Admin")]
        public ActionResult Create(){
            IEnumerable<Movie> viewmovieModel = _db.Movie.ToList();
            return View(viewmovieModel);
        }
        [HttpPost]
        public ActionResult Create(Movie obj){
            _db.Movie.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // Get
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id){
            if(id == null || id==0) return NotFound();
            var movieDb = _db.Movie.Find(id);
            if(movieDb == null) return NotFound();
            return View(movieDb);
        }
        [HttpPost]
        public ActionResult Edit(Movie obj){
            if(ModelState.IsValid){
                _db.Movie.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        
        
    }
}
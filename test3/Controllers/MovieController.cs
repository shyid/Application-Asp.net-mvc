using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test3.Models;
using test3.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;

namespace test3.Controllers
{
    public class MovieController :Controller 
    {
        private readonly test3IdentityDbContext _db;
        public  MovieController(test3IdentityDbContext db){
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
       
    }
}
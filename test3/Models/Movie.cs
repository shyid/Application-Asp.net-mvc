using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// using test3.

namespace test3.Models
{
    public class Movie
    {
        [Key]
        public int Id {get;set;}
        public String? Name {get;set;}
        public String? Description {get;set;}
        public double Price {get;set;}
        public String? ImageURL {get;set;}
        public DateTime? StartDate {get;set;}
        public DateTime? EndDate {get;set;}
        public MovieCategory MovieCategory {get;set;}

        // Relationship
        
        public int CinemaId {get;set;}
        [ForeignKey("CinemaId")]
        public Cinema cinema {get;set;}

        public Producer producer {get;set;}
         public int producerId {get;set;}
        [ForeignKey("producerId")]

        public List<Actor_Movie> actor_Movies {get;set;}
    }
}
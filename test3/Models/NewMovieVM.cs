using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test3.Models
{
    public class NewMovieVM
    {
        public String? Name {get;set;}
        public String? Description {get;set;}
        public double Price {get;set;}
        public String? ImageURL {get;set;}
        public DateTime StartDate {get;set;}
        public DateTime EndDate {get;set;}
        public MovieCategory MovieCategory {get;set;}

        // Relationship
        
        public int CinemaId {get;set;}
        public int ProducerId {get;set;}
        public int ActorId {get;set;}
        
    }
}
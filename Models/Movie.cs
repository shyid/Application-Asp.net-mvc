using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket.Models
{
    public class Movie
    {
        public int Id {get;set;}
        public String? Name {get;set;}
        public DateTime? ReleaseDate {get;set;}
        public Genre Genre {get;set;}
    }
}
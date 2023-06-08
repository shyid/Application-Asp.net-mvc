using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test3.Models
{
    public class Cinema
    {
        [Key]
        public int Id {get;set;}
        public string? Logo {get;set;}
        public string? PullName {get;set;}
        public string? Discription {get;set;}

        // Relationship
        public List<Movie> movies {get;set;}
    }
}
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
        [Display(Name = "Cinema Logo")]
        public string? Logo {get;set;}
        [Display(Name = "Cinema Name")]
        public string? FullName {get;set;}
        [Display(Name = "Discription")]
        public string? Discription {get;set;}

        // Relationship
        public List<Movie> movies {get;set;}
    }
}
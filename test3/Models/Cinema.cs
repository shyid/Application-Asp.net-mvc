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
        [Required(ErrorMessage = "Logo is required")]
        public string? Logo {get;set;}

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 100 chars")]  

        public string? FullName {get;set;}

        [Display(Name = "Discription")]
        [Required(ErrorMessage = "Discription is required")]
        public string? Discription {get;set;}

        // Relationship
        public List<Movie>? movies {get;set;}
    }
}
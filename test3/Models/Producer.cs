using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test3.Models
{
    public class Producer
    {
        [Key]
        public int Id {get;set;}
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string? ProfilePictureURL {get;set;}

        [Display(Name = "FullName")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 100 chars")]  

        public string? FullName {get;set;}
        
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string? Bio {get;set;}

        // Relationship
        public List<Movie>? movies {get;set;}
    }
}
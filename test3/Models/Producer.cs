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
        public string? ProfilePictureURL {get;set;}
        [Display(Name = "FullName")]
        public string? FullName {get;set;}
        
        [Display(Name = "Biography")]
        public string? Bio {get;set;}

        // Relationship
        public List<Movie> movies {get;set;}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace test3.Areas.Identity.Data
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name ="Full Name")]
        public string FullName {get;set;}
        public string? LastName {get;set;}
    }
}
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using test3.Areas.Identity.Data.Cart;

namespace test3.Models
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; }

        public double ShoppingCartTotal { get; set; }
    }
}
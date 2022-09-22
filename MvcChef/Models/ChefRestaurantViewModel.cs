using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcChef.Models
{
    public class ChefRestaurantViewModel
    {
        public List<Chef> Chefs { get; set; }
        public SelectList Restaurants { get; set; }
        public string? ChefRestaurant { get; set; }
        public string? SearchStringFN { get; set; }
        public string? SearchStringLN { get; set; }
    }
}

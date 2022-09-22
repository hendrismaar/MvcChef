using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcChef.Models
{
    public class Chef
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "The chef's first name must be capitalized.")]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "The chef's last name must be capitalized.")]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(40)]
        public string Restaurant { get; set; }
        [Required]
        [Display(Name = "Michelin Stars")]
        [Range(0,5)]
        public int MichelinStars { get; set; }
    }
}

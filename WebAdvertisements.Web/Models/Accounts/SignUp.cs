using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvertisements.Web.Models.Accounts
{
    public class SignUp
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]

        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage ="Password must be 6 character long!")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and its confirmation do not match")]
        public string ConfirmPassword { get; set; }
    }
}

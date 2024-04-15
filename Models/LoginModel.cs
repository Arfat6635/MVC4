using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 3)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 3)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Confirm Password does not match")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
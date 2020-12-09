using System;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [StringLength(100)]
        [MinLength(8)]
        [DataType("Password")]
        public String Password { get; set; }

        [Required]
        [DataType("Password")]
        [Compare("Password")]
        public String ConfirmPassword { get; set; }
    }
}
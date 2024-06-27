using HPlus.Ecommerce.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HPlus.Ecommerce.Models
{
    public class Login
    {
        [Required]
        [EmailAddress(ErrorMessage = "Usernames must be valid email address")]
        public string Username { get; set; }
        [Required]
        [CommonPasswords(ErrorMessage = "This password is too common")]
        [MinLength(8, ErrorMessage = "This password is too short")]
        public string Password { get; set; }
    }
}
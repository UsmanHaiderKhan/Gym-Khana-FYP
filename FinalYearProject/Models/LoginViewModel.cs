﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalYearProject.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login Id")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email Not Varified !!")]
        public string Loginid { get; set; }
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Please Enter More The 6 Char")]
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool Rememberme { get; set; }
    }
}
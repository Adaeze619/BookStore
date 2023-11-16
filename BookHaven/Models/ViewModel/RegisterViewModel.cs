﻿using System.ComponentModel.DataAnnotations;

namespace BookHaven.UI.Models.ViewModel
{
    public class RegisterViewModel
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

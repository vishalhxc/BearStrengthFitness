﻿using System.ComponentModel.DataAnnotations;

namespace Bearstrength.ViewModels
{

    /// <summary>
    /// View model to implement Login form
    /// </summary>
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

}

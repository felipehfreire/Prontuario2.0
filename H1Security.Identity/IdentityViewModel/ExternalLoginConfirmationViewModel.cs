﻿using System.ComponentModel.DataAnnotations;

namespace H1Security.Identity.IdentityViewModel
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
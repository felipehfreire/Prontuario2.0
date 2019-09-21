using System.ComponentModel.DataAnnotations;

namespace H1Security.Identity.IdentityViewModel
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace H1Security.Identity.IdentityViewModel
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
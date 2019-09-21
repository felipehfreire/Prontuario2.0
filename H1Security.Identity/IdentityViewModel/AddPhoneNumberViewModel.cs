using System.ComponentModel.DataAnnotations;

namespace H1Security.Identity.IdentityViewModel
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}
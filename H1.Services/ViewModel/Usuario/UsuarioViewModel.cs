using System.ComponentModel.DataAnnotations;

namespace H1.Services.ViewModel.Usuario
{
    public class UsuarioViewModel
    {
        
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Nome")]
        [MaxLength(100)]
        public string Nome { get; set; }
        public string Tratamento { get; set; }

        [Display(Name = "Código Colaborador SAP")]
        public string CodigoColaboradorSAP { get; set; }

        [Display(Name = "Empresa")] 
        public int? CodigoEmpresa { get; set; }
        [Display(Name = "Especialidade")]
        public string Code { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}

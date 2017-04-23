using System.ComponentModel.DataAnnotations;

namespace GigHub.V‪iewModels
{

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
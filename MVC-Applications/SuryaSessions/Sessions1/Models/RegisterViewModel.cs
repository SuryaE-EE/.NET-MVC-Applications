using System.ComponentModel.DataAnnotations;

namespace Sessions1.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password shoudl same as earlier")]
        public string ConfirmPassword { get; set; }



    }
}

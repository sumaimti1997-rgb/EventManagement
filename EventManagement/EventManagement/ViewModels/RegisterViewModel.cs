using System.ComponentModel.DataAnnotations;

namespace EventManagement.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public int Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public int Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public int Password { get; set; }

        [Required(ErrorMessage = "Conform password is required.")]
        public int ConformPassword { get; set; }
    }
}

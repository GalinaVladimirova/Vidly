using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Номер документа")]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name ="Номер телефона")]
        public string Phone { get; set; }

    }
}

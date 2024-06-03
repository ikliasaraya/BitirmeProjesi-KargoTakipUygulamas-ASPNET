using System.ComponentModel.DataAnnotations;

namespace KargoTakipUygulaması.Models
{
    public class EditUserViewModel
    {
        [Required]
        [Display(Name = "Ad")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"\d{11}", ErrorMessage = "Kimlik numarası 11 haneli ve sadece rakamlardan oluşmalıdır.")]
        [Display(Name = "Kimlik Numarası")]
        public string IdentityNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

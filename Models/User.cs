using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KargoTakipUygulaması.Models
{
    public class User : IdentityUser
    {
        public string Role { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"\d{11}", ErrorMessage = "Kimlik numarası 11 haneli ve sadece rakamlardan oluşmalıdır.")]
        public string IdentityNumber { get; set; } = string.Empty;

        public ICollection<Cargo> SentCargos { get; set; } = new List<Cargo>();
        public ICollection<Cargo> ReceivedCargos { get; set; } = new List<Cargo>();
    }
}

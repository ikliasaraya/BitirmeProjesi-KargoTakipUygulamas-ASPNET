using System;
using System.ComponentModel.DataAnnotations;

namespace KargoTakipUygulaması.Models
{
    public class CargoStatus
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string CargoId { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public Cargo Cargo { get; set; }
    }
}

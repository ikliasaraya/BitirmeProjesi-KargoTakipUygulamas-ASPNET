using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KargoTakipUygulaması.Models
{
    public class Cargo
    {
        [Key]
        [Display(Name = "Takip Kodu")]
        public string Id { get; set; }

        [Required]
        public string SenderId { get; set; }

        [Display(Name = "Alıcı T.C. Kimlik Numarası")]
        [Required]
        public string RecipientIdentityNumber { get; set; }

        [Display(Name = "Alıcı Adı")]
        [Required]
        public string RecipientName { get; set; }

        [Display(Name = "Alıcı Soyadı")]
        [Required]
        public string RecipientSurname { get; set; }

        [Display(Name = "Durum")]
        public string Status { get; set; }

        [Display(Name = "Gönderim Tarihi")]
        [Required]
        public DateTime ShipmentDate { get; set; }

        [Display(Name = "Teslim Tarihi")]
        public DateTime? DeliveryDate { get; set; }

        [Display(Name = "Adres")]
        [Required]
        public string Address { get; set; }

        public User Sender { get; set; }

        public double? Latitude { get; set; } = 37.0; // Adana enlemi
        public double? Longitude { get; set; } = 35.3213; // Adana boylamı

        public ICollection<CargoStatus> CargoStatuses { get; set; } = new List<CargoStatus>();
        public ICollection<CargoLocation> CargoLocations { get; set; } 

    }
}

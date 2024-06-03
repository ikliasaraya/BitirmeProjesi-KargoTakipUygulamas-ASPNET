using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace KargoTakipUygulaması.Models
{
    public class User : IdentityUser
    {
        //ROLE EKLEME - GERI KALANLAR IDENTITYUSERDAN GELIYOR
        public string Role { get; set; } = string.Empty;

        public ICollection<Cargo> SentCargos { get; set; } = new List<Cargo>();
        public ICollection<Cargo> ReceivedCargos { get; set; } = new List<Cargo>();
    }
}
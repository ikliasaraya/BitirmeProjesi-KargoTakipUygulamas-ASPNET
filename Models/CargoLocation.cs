namespace KargoTakipUygulaması.Models
{
    public class CargoLocation
    {
        public int Id { get; set; }
        public string CargoId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Timestamp { get; set; }

        public Cargo Cargo { get; set; }
    }
}

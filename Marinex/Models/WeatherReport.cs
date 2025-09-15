namespace Marinex.Models
{
    public class WeatherReport
    {
        public int ReportID { get; set; }
        public string Reporter { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Severity { get; set; }
        public string Description { get; set; }

        // Relasi
        public int UserID { get; set; }
        public User User { get; set; }

        // Methods sesuai diagram
        public bool Validate()
        {
            return !string.IsNullOrEmpty(Location) && !string.IsNullOrEmpty(Category);
        }
    }
}

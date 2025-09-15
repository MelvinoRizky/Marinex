namespace Marinex.Models
{
    public class Weather
    {
        public int WeatherID { get; set; }
        public string Location { get; set; }
        public double Temperature { get; set; }
        public string Wind { get; set; }
        public string SeaCondition { get; set; }

        // Relasi
        public int VoyageID { get; set; }
        public Voyage Voyage { get; set; }

        // Methods sesuai diagram
        public string GetSummary()
        {
            return $"Weather at {Location}: {Temperature}°C, Wind {Wind}, Sea {SeaCondition}";
        }
    }
}

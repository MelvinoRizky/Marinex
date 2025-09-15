using System;

namespace Marinex.Models
{
    public class Voyage
    {
        public int VoyageID { get; set; }
        public string From { get; set; }
        public string Destination { get; set; }
        public TimeSpan EstimatedDuration { get; set; }

        // Relasi
        public int ShipID { get; set; }
        public Ship Ship { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }

        public Weather Weather { get; set; }

        // Methods sesuai diagram
        public DateTime CalculateETA(DateTime start)
        {
            return start.Add(EstimatedDuration);
        }

        public string GetReport()
        {
            return $"Voyage from {From} to {Destination}, ETA: {EstimatedDuration.TotalHours} hours";
        }
    }
}

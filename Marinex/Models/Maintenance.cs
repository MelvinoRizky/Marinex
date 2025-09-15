using System;

namespace Marinex.Models
{
    public class Maintenance
    {
        public int MaintenanceID { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        // Relasi
        public int UserID { get; set; }
        public User User { get; set; }
        public int ShipID { get; set; }
        public Ship Ship { get; set; }

        // Methods sesuai diagram
        public void MarkAsDone()
        {
            Status = "Done";
        }
    }
}

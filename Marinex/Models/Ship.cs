using System.Collections.Generic;

namespace Marinex.Models
{
    public class Ship
    {
        public int ShipID { get; set; }
        public string ShipName { get; set; }
        public string ShipType { get; set; }
        public string Owner { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }

        // Navigasi
        public List<UserShip> UserShips { get; set; } = new();
        public List<Voyage> Voyages { get; set; } = new();
        public List<Maintenance> Maintenances { get; set; } = new();

        // Methods sesuai diagram
        public void StartVoyage() => Status = "Sailing";
        public void EndVoyage() => Status = "Docked";
    }
}

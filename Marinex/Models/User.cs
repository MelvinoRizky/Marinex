using System.Collections.Generic;

namespace Marinex.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }

        // Navigasi
        public List<WeatherReport> Reports { get; set; } = new();
        public List<UserShip> UserShips { get; set; } = new();
        public List<Voyage> Voyages { get; set; } = new();
        public List<Maintenance> Maintenances { get; set; } = new();
    }
}

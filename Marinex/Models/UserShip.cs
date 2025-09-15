using System;

namespace Marinex.Models
{
    public class UserShip
    {
        public int UserShipID { get; set; }
        public int UserID { get; set; }
        public int ShipID { get; set; }
        public DateTime JoinDate { get; set; }
        public string Status { get; set; }

        // Navigasi
        public User User { get; set; }
        public Ship Ship { get; set; }
    }
}

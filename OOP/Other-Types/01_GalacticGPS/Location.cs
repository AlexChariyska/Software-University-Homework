using System;

namespace GalacticGPS
{
    public struct Location
    {
        private double Latitude { get; set; }
        private double Longitude { get; set; }
        private Planet Planet { get; set; }
        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            string planetLoc = string.Format(
                "Your coordinates: {0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
            return planetLoc;
        }
    }
}

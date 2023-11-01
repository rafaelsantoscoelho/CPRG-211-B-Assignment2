using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveless.Backend.Entities;

namespace Traveless.Backend
{
    internal class AirportManager
    {
        // Fields

        private List<Airport> _airports;
        private const string _AIRPORTS_FILE = "../../../../Backend/Data/airports.csv";

        // Properties

        public IList<Airport> Airports
        {
            get { return this._airports.ToList(); }
        }

        // Methods

        public AirportManager()
        {
            this._airports = new List<Airport>();
        }

        public Airport FindAirport(string code)
        {
            foreach (Airport airport in this._airports)
            {
                if (airport.Code == code)
                {
                    return airport;
                }
            }

            return null;
        }

        public void LoadAirports()
        {
            string[] lines = File.ReadAllLines(_AIRPORTS_FILE);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string code = parts[0];
                string name = parts[1];

                Airport airport = new Airport(code, name);
                _airports.Add(airport);
            }
        }
    }
}

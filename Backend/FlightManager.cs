using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveless.Backend.Entities;

namespace Traveless.Backend
{
    internal class FlightManager
    {
        // Fields

        private List<Flight> _flights;
        private const string _FLIGHTS_FILE = "../../../../Backend/Data/flights.csv";

        // Properties

        public IList<Flight> Flights
        {
            get { return this._flights.ToList(); }
        }

        // Methods

        public FlightManager()
        {
            this._flights = new List<Flight>();
        }

        public void LoadFlights()
        {
            string[] lines = File.ReadAllLines(_FLIGHTS_FILE);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string code = parts[0];
                string from = parts[2]; 
                string to = parts[3];
                string weekday = parts[4];
                string time = parts[5];
                int seats = int.Parse(parts[6]);
                decimal costPerSeat = decimal.Parse(parts[7]);

                Flight flight = new Flight(code, from, to, weekday, time, seats, costPerSeat);
                _flights.Add(flight);
            }
        }

        public Flight FindFlightByCode(string code)
        {
            foreach (Flight flight in _flights)
            {
                if (flight.Code == code)
                {
                    return flight;
                }
            }

            return null;
        }
    }
}

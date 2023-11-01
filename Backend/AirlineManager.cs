using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveless.Backend.Entities;

namespace Traveless.Backend
{
    internal class AirlineManager
    {
        // Fields

        private List<Airline> _airlines;
        private const string _AIRLINES_FILE = "../../../../Backend/Data/airlines.csv";

        // Properties

        public IList<Airline> Airlines
        {
            get { return this._airlines.ToList(); }
        }

        // Methods

        public AirlineManager()
        {
            this._airlines = new List<Airline>();
        }

        public Airline FindAirline(string code)
        {
            foreach (Airline airline in this._airlines)
            {
                if (airline.Code == code)
                {
                    return airline;
                }
            }

            return null;
        }

        public void LoadAirlines()
        {
            string[] lines = File.ReadAllLines(_AIRLINE_FILE);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string code = parts[0];
                string name = parts[1];

                Airline airline = new Airline(code, name);
                _airlines.Add(airline);
            }
        }
    }
}

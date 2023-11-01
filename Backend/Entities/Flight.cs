using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Backend.Entities
{
    internal class Flight
    {
        // Fields

        private string _code;
        private string _from;
        private string _to;
        private string _weekday;
        private string _time;
        private int _seats;
        private decimal _costPerSeat;

        // Properties

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public decimal CostPerSeat
        {
            get { return _costPerSeat; }
            set { _costPerSeat = value; }
        }

        public string From
        {
            get { return _from; }
            set { _from = value; }
        }

        public bool IsDomestic
        {
            get { return _from == _to; }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string To
        {
            get { return _to; }
            set { _to = value; }
        }

        public int TotalSeats
        {
            get { return _seats; }
            set { _seats = value; }
        }

        public string Weekday
        {
            get { return _weekday; }
            set { _weekday = value; }
        }

        // Methods
        public Flight() { }

        public Flight(string code, string from, string to, string weekday, string time, int seats, decimal costPerSeat)
        {
            this.Code = code;
            this.From = from;
            this.To = to;
            this.Weekday = weekday;
            this.Time = time;
            this.TotalSeats = seats;
            this.CostPerSeat = costPerSeat;
        }

        public bool Equals(Flight other)
        {
            if (this.Code != other.Code) return false;
            if (this.From != other.From) return false;
            if (this.To != other.To) return false;
            if (this.Weekday != other.Weekday) return false;
            if (this.Time != other.Time) return false;
            if (this.TotalSeats != other.TotalSeats) return false;
            if (this.CostPerSeat != other.CostPerSeat) return false;

            return true;
        }

        // TO-DO

        public bool Equals(Object obj) { return false; }
    }
}

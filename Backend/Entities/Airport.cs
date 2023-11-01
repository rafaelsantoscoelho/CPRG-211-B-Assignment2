using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Backend.Entities
{
    internal class Airport
    {
        // Fields

        private string _code;
        private string _name;

        // Properties

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Methods

        public override string ToString()
        {
            return "";
        }
    }
}

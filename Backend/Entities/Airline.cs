﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Backend.Entities
{
    internal class Airline
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

        public Airline(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public override string ToString()
        {
            return "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    public class Address : Displayable
    {
        private string _street;
        public string street { set { _street = value; } }

        private string _number;
        public string number { set { _number = value; } }

        public override string GetDisplayText()
        {
            return $"{_street} number {_number}";
        }
    }
}

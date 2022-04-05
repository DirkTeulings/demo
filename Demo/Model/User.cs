using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    public class User : Displayable
    {
        private string _name;
        public string name { set { _name = value; } }

        private string _age;
        public string age { set { _age = value; } }

        private Address _address;
        public Address address { set { _address = value; } }

        public override string GetDisplayText()
        {
            return $"{_name} you are {_age} years old and live at {_address.GetDisplayText()}";
        }
    }
}

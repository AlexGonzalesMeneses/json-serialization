using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class Contact
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Phone> Phones { get; set; }
        public DateTime Birthday { get; set; }
    }
}

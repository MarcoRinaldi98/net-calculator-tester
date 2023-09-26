using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoTelefonico
{
    public class Contact
    {
        // ATTRIBUTI
        public string Name { get; }
        public string PhoneNumber { get; }

        // COSTRUTTORE
        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        // METODI
        public override string ToString()
        {
            return @$"
Nome: {Name};
Telefono: {PhoneNumber};
            ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoTelefonico
{
    public class PhoneBook
    {
        // ATTRIBUTI
        private List<Contact> contactsByName = new List<Contact>();
        private Dictionary<string, Contact> contactsByPhoneNumber = new Dictionary<string, Contact>();

        // METODI
        // Metodo per aggiungere un contatto
        public void AddContact(string name, string phoneNumber)
        {
            Contact contact = new Contact(name, phoneNumber);
            contactsByName.Add(contact);
            contactsByPhoneNumber[phoneNumber] = contact;
        }

        // Metodo per cercare un contato dal nome passato
        public List<Contact> SearchByName(string name)
        {
            return contactsByName.Where(contact => contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Metodo per cercare un contatto dal numero di telefono passato
        public List<Contact> SearchByPhoneNumber(string phoneNumber)
        {
            if (contactsByPhoneNumber.TryGetValue(phoneNumber, out Contact contact))
            {
                return new List<Contact> { contact };
            }
            return new List<Contact>();
        }
    }
}

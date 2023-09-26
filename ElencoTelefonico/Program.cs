using System.Diagnostics;

namespace ElencoTelefonico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            // Genera 2 milioni di contatti random
            Random random = new Random();
            for (int i = 0; i < 2000000; i++)
            {
                string name = "Name" + i;
                string phoneNumber = "+39" + random.Next(100000000, 999999999);
                phoneBook.AddContact(name, phoneNumber);
            }

            // Ricerca per nome e verifica il tempo impiegato
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string searchName = "Name10"; 
            List<Contact> nameResults = phoneBook.SearchByName(searchName);
            sw.Stop();
            if (nameResults.Count > 0)
            {
                foreach (Contact contact in nameResults)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine($"Non sono stati trovati contatti con nome {searchName}!");
            }
            Console.WriteLine($"Ricerca per nome: {sw.ElapsedMilliseconds} ms");

            Console.WriteLine(Environment.NewLine);

            // Ricerca per telefono e verifica il tempo impiegato
            sw.Reset();
            sw.Start();
            string searchPhoneNumber = "+39300036691"; 
            List<Contact> phoneResults = phoneBook.SearchByPhoneNumber(searchPhoneNumber);
            sw.Stop();
            if (phoneResults.Count > 0)
            {
                foreach (Contact contact in phoneResults)
                {
                    Console.WriteLine(contact);
                }
            } else
            {
                Console.WriteLine($"Non sono stati trovati contatti con numero di telefono {searchPhoneNumber}!");
            }
            Console.WriteLine($"Ricerca per telefono: {sw.ElapsedMilliseconds} ms");
        }
    }
}
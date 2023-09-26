using ElencoTelefonico;
using System.Diagnostics;

namespace ElencoTelefonicoTestProject
{
    public class PhoneBookTest
    {
        private PhoneBook phoneBook;

        [SetUp]
        public void Setup()
        {
            phoneBook = new PhoneBook();
            // Aggiungo alcuni contatti per testare
            phoneBook.AddContact("Name1", "+391234567");
            phoneBook.AddContact("Name2", "+391234568");
        }

        [Test]
        public void SearchByName_ShouldExecuteInUnder10Milliseconds()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            phoneBook.SearchByName("Name1");
            stopwatch.Stop();

            Assert.Less(stopwatch.ElapsedMilliseconds, 10);
        }

        [Test]
        public void SearchByPhoneNumber_ShouldExecuteInUnder10Milliseconds()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            phoneBook.SearchByPhoneNumber("+391234567");
            stopwatch.Stop();

            Assert.Less(stopwatch.ElapsedMilliseconds, 10);
        }
    }
}
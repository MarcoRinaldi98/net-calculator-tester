using System.ComponentModel;

namespace net_calculator_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"La somma tra 2 e 3 fa {Calculator.Add(2, 3)};");

            Console.WriteLine($"La sottrazione tra 5 e 2 fa {Calculator.Subtract(5, 2)};");

            Console.WriteLine($"La divisione tra 6 e 2 fa {Calculator.Divide(6, 2)};");

            Console.WriteLine($"La moltiplicazione tra 6 e 2 fa {Calculator.Multiply(6, 2)};");
        }
    }
}
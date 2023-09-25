using net_calculator_tester;

namespace CalculatorTestProject
{
    public class CalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        // Test funzione Add del Calculator
        public void AddTest()
        {
            Assert.That(Calculator.Add(2, 3), Is.EqualTo(5));
        }

        [Test]
        // Test funzione Subtract del Calculator
        public void SubtractTest()
        {
            Assert.That(Calculator.Subtract(5, 2), Is.EqualTo(3));
        }

        [Test]
        // Test funzione Subtract del Calculator con numeri invertiti
        public void InvertSubtractTest()
        {
            Assert.That(Calculator.Subtract(2, 5), Is.EqualTo(3));
        }

        [Test]
        // Test funzione Divide del Calculator
        public void DivideTest()
        {
            Assert.That(Calculator.Divide(6, 2), Is.EqualTo(3));
        }

        [Test]
        // Test funzione Divide del Calculator con uno dei parametri a 0
        public void DivideZeroTest()
        {
            Assert.That(Calculator.Divide(6, 0), Is.EqualTo(0));
        }

        [Test]
        // Test funzione Multiply del Calculator
        public void MultiplyTest()
        {
            Assert.That(Calculator.Multiply(3, 2), Is.EqualTo(6));
        }

        [Test]
        // Test funzione Multiply del Calculator con uno dei parametri a 0
        public void MultiplyZeroTest()
        {
            Assert.That(Calculator.Multiply(0, 3), Is.EqualTo(0));
        }
    }
}
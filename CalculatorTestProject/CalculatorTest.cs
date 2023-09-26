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
        [TestCase(2, 3, 5)]
        // Test funzione Add del Calculator con TestCase
        public void AddTest(float num1, float num2, float result)
        {
            Assert.That(Calculator.Add(num1, num2), Is.EqualTo(result));
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
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(6, 0));
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
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
        public void AddTest()
        {
            Assert.That(Calculator.Add(2, 3), Is.EqualTo(5));
        }

        [Test]
        public void SubtractTest()
        {
            Assert.That(Calculator.Subtract(5, 2), Is.EqualTo(3));
        }

        [Test]
        public void InvertSubtractTest()
        {
            Assert.That(Calculator.Subtract(2, 5), Is.EqualTo(3));
        }

        [Test]
        public void DivideTest()
        {
            Assert.That(Calculator.Divide(6, 2), Is.EqualTo(3));
        }

        [Test]
        public void DivideZeroTest()
        {
            Assert.That(Calculator.Divide(6, 0), Is.EqualTo(0));
        }

        [Test]
        public void MultiplyTest()
        {
            Assert.That(Calculator.Multiply(3, 2), Is.EqualTo(6));
        }

        [Test]
        public void MultiplyZeroTest()
        {
            Assert.That(Calculator.Multiply(0, 3), Is.EqualTo(0));
        }
    }
}

namespace TestProject
{
    namespace Calculator.Tests
    {
        public class CalculatorTests
        {
            private readonly CalculatorTests _calc;

            public object Assert { get; private set; }

            public CalculatorTests()
            {
                _calc = new CalculatorTests();
            }

            [Fact]
            public void Add_ShouldReturnCorrectSum()
            {
                int result = _calc.Add(5, 3);
                bool isExpectedSum = Assert.Equals(8, result);
            }

            private int Add(int v1, int v2)
            {
                throw new NotImplementedException();
            }

            [Fact]
            public void SubtractShouldReturnCorrectDifference()
            {
                int result = _calc.Subtract_ShouldReturnCorrectDifference(10, 4);
                Assert.Equals(6, result);
            }

            private int Subtract_ShouldReturnCorrectDifference(int v1, int v2)
            {
                throw new NotImplementedException();
            }

            [Fact]
            public void DivideByZeroShouldThrowException()
            {
                Assert.Throws<DivideByZeroException>(() => _calc.Divide_ByZero_ShouldThrowException(10, 0));
            }

            private void Divide_ByZero_ShouldThrowException(int v1, int v2)
            {
                throw new NotImplementedException();
            }
        }

        internal class FactAttribute : Attribute
        {
        }
    }
}


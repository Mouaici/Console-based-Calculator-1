using System.Runtime.Intrinsics.X86;
using static New_calculator.Program;





namespace UnitTest_New_calculator
{
    public class UnitTest1
    {
        private int result;
        private int number1;
        private int number2;

      

        [Fact]

        public void TestAdd()

        {
            int result = Add(5, 8);
            Assert.Equal(13, result);

        }


        [Fact]
        public void TestSubtract()
        {
            int result = Subtract(5, 8);
            Assert.Equal(-3, result);
        }

        [Fact]
        public void TestMultiply()
        {
            int result = Multiply(5, 8);
            Assert.Equal(40, result);
        }

        [Fact]
        public void TestDivide()
        {
            int result = _Divide(8, 4);
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestDivideByZero()
        {
            int result = _Divide(8, 0);
            Assert.Equal(0, result);
        }


    }
}

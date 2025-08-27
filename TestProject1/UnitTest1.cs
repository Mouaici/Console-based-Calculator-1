using System.Runtime.Intrinsics.X86;

namespace TestProject1
{
    public class UnitTest1
    {
        private int result;
        private int number1;
        private int number2;

        [Fact]
#pragma warning disable xUnit1028 // Test method must have valid return type
        public int TestAdd()
#pragma warning restore xUnit1028 // Test method must have valid return type
        {
            return number1 + number2;
        }

        private int Add(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        [Fact]
#pragma warning disable xUnit1028 // Test method must have valid return type
        public int TestSubtract()
#pragma warning restore xUnit1028 // Test method must have valid return type
        {
            return number1 - number2;
        }

        private int Subtract(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        [Fact]
#pragma warning disable xUnit1028 // Test method must have valid return type
        public int TestMultiply()
#pragma warning restore xUnit1028 // Test method must have valid return type
        {
            return number1 * number2;
        }

        private int Multiply(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        [Fact]
        public int TestDivide()
        {
            if (number2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0; // or throw an exception
            }
            else
            {
                return number1 / number2;
            }
        }
        private int Divide(int v1, int v2)
        {
            throw new NotImplementedException();
        }
        


    }
}

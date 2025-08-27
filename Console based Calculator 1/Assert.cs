using System;

namespace xUnit
{
    internal class Assert
    {
        internal static void Equal(int v, int result)
        {
            throw new NotImplementedException();
        }

        internal static void Equal(int expected, int v, object value, int actual_sut)
        {
            throw new NotImplementedException();
        }

        // Removed invalid and duplicate method declarations with stray characters
        internal static void Equal(int expected, object value, int actual)
        {
            throw new NotImplementedException();
        }

        internal static void Throws<T>(Func<int> value)
        {
            throw new NotImplementedException();
        }

        internal static void Equal(object intv, object inresult)
        {
            throw new NotImplementedException();
        }

        internal static void Equal(object vv, in int result)
        {
            throw new NotImplementedException();
        }
    }
}
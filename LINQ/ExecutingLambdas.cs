using System;

namespace LINQ
{
    public class ExecutingLambdas
    {
        public void DoIt()
        {
            Action printData = () => Console.WriteLine(DateTime.Now);
            Action<int, int> printNumbers = (x, y) => Console.WriteLine(x + " and " + y);
            Func<int, int, int> multiply = (x, y) => x * y;
            Func<int, bool> isMyNumberSuper = (x) => x % 2 == 0;

            printData();
            printNumbers(1, 2);
            var i = multiply(1, 2);
            var myNumberSuper = isMyNumberSuper(4);
        }

    }
}

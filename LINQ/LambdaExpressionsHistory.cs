using System;
using System.Text.RegularExpressions;

namespace LINQ
{
    public class LambdaExpressionsHistory
    {
        public void DoIt()
        {
            var ints = new[] { 1, 2, 3, 4, 5, 6, 7, 9, 0 };

            Array.Find(ints, Match); // named method - before C# 2.0 

            Array.Find(ints, delegate(int i) { return i % 2 == 0; }); // delegate - C# 2.0

            Array.Find(ints, i => i % 2 == 0); // lambda!!! - C# 3.0   
        }

        private bool Match(int i)
        {
            return i%2 == 0;
        }
    }
}

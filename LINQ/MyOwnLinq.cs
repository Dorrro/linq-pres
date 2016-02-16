using System;
using System.Collections.Generic;

namespace LINQ
{
    public static class MyOwnLinq
    {
        public static IEnumerable<double> GiveMePowerOf2(this IEnumerable<int> input)
        {
            foreach (var i in input)
            {
                Console.WriteLine(i + " has been picked");
                yield return Math.Pow(2, i);
            }
        }

        public static IEnumerable<double> __GiveMePowerOf2(this IEnumerable<int> input)
        {
            var output = new List<double>();
            foreach (var i in input)
            {
                Console.WriteLine(i + " has been picked");
                output.Add(Math.Pow(2, i));
            }

            return output;
        }
    }
}

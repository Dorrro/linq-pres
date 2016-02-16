using System;
using System.Linq;

namespace LINQ
{
    public class CreatingOurOwnLinq
    {
        public void DoIt()
        {
            var ints = new [] { 1, 2, 3, 4, 5, 6, 7, 8};

            Func<double, bool> powerOf2IsGt10 = powerOf2 => powerOf2 > 10;

            {
                var gt10 = ints.__GiveMePowerOf2().FirstOrDefault(powerOf2IsGt10);
            }
            {
                var gt10 = ints.GiveMePowerOf2().FirstOrDefault(powerOf2IsGt10);   
            }            
        }
    }
}
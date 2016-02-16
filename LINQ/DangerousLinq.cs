using System;
using System.Linq;

namespace LINQ
{
    public class DangerousLinq
    {
        public void DoIt()
        {
            var ints = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            // Ex. 1
            {
                Console.Clear();
                int minimumNumber = 3;

                var gt3 = ints.Where(i => i > minimumNumber);

                minimumNumber = 5;
                var gt5 = ints.Where(i => i > minimumNumber);

                Console.WriteLine(gt3.Count() + ", " + gt5.Count());
            }

            // Ex. 2
            {
                Console.Clear();
                var giveMePowerOf2 = ints.GiveMePowerOf2().Where(p => p < 100);

                if (giveMePowerOf2.Count() > 5)
                {
                    foreach (var po2 in giveMePowerOf2)
                    {
                        Console.WriteLine(po2);
                    }
                }
            }
        }
    }
}
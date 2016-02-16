using System;
using System.Linq;

namespace LINQ
{
    public class LinqInAction
    {
        public void DoIt()
        {
            var ints = new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            // SELECT
            var doubled = ints.Select(i => i*2);
            var woohaaNewObjects = ints.Select(i => new { Date = DateTime.Now - i.Minutes(), IsDivisibleBy2 = i % 2});

            // WHERE
            var divisibleBy2 = ints.Where(i => i % 2 == 0);

            // FIRST OR DEFAULT
            var gt6 = ints.FirstOrDefault(i => i > 6);

            // ANY
            var any = ints.Any(i => divisibleBy2.Contains(i) && i == gt6);

            // Enumerable
        }
    }
}
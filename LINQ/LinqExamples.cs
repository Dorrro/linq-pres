using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class LinqExamples
    {
        public void DoIt()
        {
            // Ex. 1             
            {
                var ints = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                var superbClasses = new List<SuperbClass>();

                for (var i = 0; i < ints.Length; i++)
                {
                    if (ints[i] % 2 == 0)
                    {
                        var superbClass = new SuperbClass { SuperbInt = ints[i] };
                        superbClasses.Add(superbClass);
                    }
                }

                var superbLinqClasses =
                    ints
                        .Where(i => i % 2 == 0)
                        .Select(i => new SuperbClass { SuperbInt = i });
            }

            // Ex. 2             
            {
                var ints = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
                var skip = true;
                var list = new List<int>();

                for (var i = 0; i < ints.Length; i++)
                {
                    if (ints[i]%3 == 0)
                    {
                        if (skip)
                        {
                            skip = false;
                            continue;
                        }

                        if (list.Count > 1)
                            break;

                        list.Add(ints[i]);
                    }
                }

                var myLinqList = ints.Where(i => i%3 == 0).Skip(1).Take(2);
            }
        }

        public class SuperbClass
        {
            public int SuperbInt { get; set; }
        }
    }
}
using System;

namespace LINQ
{
    public class ExtensionMethodsInAction
    {
        public void DoIt()
        {
            {
                var fiveMinutes = TimeSpan.FromMinutes(5);   
            }
            {
                var fiveMinutes = 5.Minutes();
            }
        }
    }
}

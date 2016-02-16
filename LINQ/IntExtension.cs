using System;

namespace LINQ
{
    public static class IntExtension
    {
        public static TimeSpan Minutes(this int minutes)
        {
            return TimeSpan.FromMinutes(minutes);
        }
    }
}

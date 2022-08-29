using System;
namespace Exercises
{
    public class Exercise004
    {
        const int GIGASECOND = 1000000000; // 1 gigasecond = 1000000000 seconds
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            return dateTime.AddSeconds(GIGASECOND);
        }
    }
}

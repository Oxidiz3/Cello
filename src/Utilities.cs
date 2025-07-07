using System;

namespace Cello
{
    public static class Utilities
    {
        /// <summary>
        /// Returns the number of seconds that have passed since the provided DateTime.
        /// </summary>
        /// <param name="dateTime">The DateTime to compare against DateTime.Now.</param>
        /// <returns>Seconds elapsed as a double.</returns>
        public static double TimeToNow(DateTime dateTime)
        {
            TimeSpan elapsed = DateTime.Now - dateTime;
            return elapsed.TotalSeconds;
        }
    }
}

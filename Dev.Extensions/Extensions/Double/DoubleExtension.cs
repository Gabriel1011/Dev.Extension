using System;

namespace Dev.Extensions
{
    public static class DoubleExtension
    {
        public static double ToRound(this double value, int roundBy) => Math.Round(value, roundBy);
        public static TimeSpan ToMilliseconds(this double value) => TimeSpan.FromMilliseconds(value);
        public static TimeSpan ToSeconds(this double value) => TimeSpan.FromSeconds(value);
        public static TimeSpan ToMinutes(this double value) => TimeSpan.FromMinutes(value);
        public static TimeSpan ToHours(this double value) => TimeSpan.FromHours(value);
        public static TimeSpan ToDays(this double value) => TimeSpan.FromDays(value);
    }
}

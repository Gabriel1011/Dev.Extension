using System;

namespace Dev.Extensions
{
    public static class IntExtension
    {
        public static TimeSpan ToMilliseconds(this int value) => TimeSpan.FromMilliseconds(value);
        public static TimeSpan ToSeconds(this int value) => TimeSpan.FromSeconds(value);
        public static TimeSpan ToMinutes(this int value) => TimeSpan.FromMinutes(value);
        public static TimeSpan ToHours(this int value) => TimeSpan.FromHours(value);
        public static TimeSpan ToDays(this int value) => TimeSpan.FromDays(value);
    }
}

using System;

namespace Dev.Extensions
{
    public static class DateExtension
    {
        public static DateTime StartOfDay(this DateTime date) =>
            new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);

        public static DateTime EndOfDay(this DateTime date) =>
            new DateTime(date.Year, date.Month, date.Day, 23, 59, 59, 999);

    }
}

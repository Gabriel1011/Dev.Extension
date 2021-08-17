using System;

namespace Dev.Extensions
{
  public static class StringExtension{
      public static decimal ToDecimal(this string value) => Convert.ToDecimal(value);
      public static decimal? ToDecimalNull(this string value) => value == null ? (decimal?)null : Convert.ToDecimal(value);
      public static decimal? ToDecimalZero(this string value) => Convert.ToDecimal(value ?? "0");
      public static bool IsEmpty(this string value) => value == string.Empty;
      public static bool IsNullOrEmpty(this string value) => String.IsNullOrEmpty(value);
  }
}
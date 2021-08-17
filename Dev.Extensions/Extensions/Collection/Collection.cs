using System.Collections.Generic;

namespace Dev.Extensions{
  public static class CollectionExtension
  {
    public static string ToSeparatorBy(this IEnumerable<string> value, string character) =>
      string.Join(character, value);
  }
}
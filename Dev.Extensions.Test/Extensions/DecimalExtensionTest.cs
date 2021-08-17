using System.Collections.Generic;
using Xunit;

namespace Dev.Extensions.Test
{
  public class DecimalExtensionTest
  {
    [Fact]
    public void ToSeparatorBy_Coma_List()
    {
      Assert.Equal("a, b, c", new List<string>() { "a", "b", "c" }.ToSeparatorBy(", "));
    }

    [Fact]
    public void ToSeparatorBy_Coma_Array()
    {
      Assert.Equal("a, b, c", new string[] { "a", "b", "c" }.ToSeparatorBy(", "));
    }

  }
}

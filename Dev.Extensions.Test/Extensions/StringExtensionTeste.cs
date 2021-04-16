using System;
using Xunit;

namespace Dev.Extensions.Test
{
    public class StringExtensionTeste
    {
        [Fact]
        public void ToDecimal_Convert_String_To_Decimal()
        {
          Assert.Equal(0, "0".ToDecimal());
        }

        [Fact]
        public void Convert_String_To_Decimal_If_String_Isnt_Number()
        {
          Assert.Throws<FormatException>(() => "A".ToDecimal());
        }

        [Fact]
        public void ToDecimal_Convert_String_To_Decimal_null()
        {
          string teste = null;

          Assert.Equal(null, teste.ToDecimalNull());
        }

        [Fact]
        public void Convert_String_To_Decimal_Null_If_String_Isnt_Number()
        {
          Assert.Throws<FormatException>(() => "A".ToDecimalNull());
        }

        [Fact]
        public void ToDecimal_Convert_String_To_Decimal_If_Null_Return_Zero()
        {
          string teste = null;

          Assert.Equal(0, teste.ToDecimalZero());
        }

        [Fact]
        public void Check_If_String_Is_Null_When_value_Is_Null()
        {
          string teste = null;

          Assert.Equal(true, teste.IsNull());
        }

        [Fact]
        public void Check_If_String_Is_Null_When_value_Isnt_Null()
        {
          string teste = "";

          Assert.Equal(false, teste.IsNull());
        }

        [Fact]
        public void Check_If_String_Is_Empty_When_Value_Is_Empty()
        {
          string teste = "";

          Assert.Equal(true, teste.IsEmpty());
        }

        [Fact]
        public void Check_If_String_Is_Empty_When_Value_Isnt_Empty()
        {
          string teste = "A";

          Assert.Equal(false, teste.IsEmpty());
        }


        [Fact]
        public void Check_If_String_Is_Null_Or_Empty_When_Is_Empty_And_Null()
        {
          string teste = "";
          string teste1 = null;

          Assert.Equal(true, teste.IsNullOrEmpty() && teste1.IsNullOrEmpty());
        }

        [Fact]
        public void Check_If_String_Is_Null_Or_Empty_When_Isnt_Empty_And_Null()
        {
          string teste = "a";
          string teste1 = "";

          Assert.Equal(false, teste.IsNullOrEmpty() && teste1.IsNullOrEmpty());
        }
    }
}
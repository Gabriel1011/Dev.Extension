using System;
using Dev.Extensions;

namespace Dev.Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string teste = "10";
            Console.WriteLine(teste.ToDecimal());

            teste = null;
            Console.WriteLine(teste.ToDecimalNull());

            teste = null;
            Console.WriteLine(teste.IsNull());

            teste = "";
            Console.WriteLine(teste.IsEmpty());

            teste = null;
            Console.WriteLine(teste.IsNullOrEmpty());
        }
    }
}

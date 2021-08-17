using System;
using System.Collections.Generic;
using System.Threading;
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

            var testeCollection = new List<string> {"a", "b", "c"};
            Console.WriteLine(testeCollection.ToSeparatorBy(", "));

            var testeArray = new string[] {"a", "b", "c"};
            Console.WriteLine(testeArray.ToSeparatorBy(", "));

            double testeRound = 0.555555;
            Console.WriteLine(testeRound.ToRound(2));

            DateTime data = DateTime.Now;
            Console.WriteLine(data.StartOfDay());

            Console.WriteLine(data.EndOfDay());

            decimal? dt = null;
            Console.WriteLine(dt.IsNull());

            Console.WriteLine(1.ToSeconds());
        }
    }
}

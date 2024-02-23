using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture =
                CultureInfo.InvariantCulture;

            Console.WriteLine("Insere 4 números reais:\n");
            string str1 = Console.ReadLine();
            float num1 = float.Parse(str1);

            string str2 = Console.ReadLine();
            float num2 = float.Parse(str2);

            string str3 = Console.ReadLine();
            float num3 = float.Parse(str3);

            string str4 = Console.ReadLine();
            float num4 = float.Parse(str4);

            Console.WriteLine($"{num1,6:f2}");
            Console.WriteLine($"{num2,6:f2}");
            Console.WriteLine($"{num3,6:f2}");
            Console.WriteLine($"{num4,6:f2}");


        }
    }
}

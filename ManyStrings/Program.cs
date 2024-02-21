using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string quadrado = "Ado A Ado cada um no seu quadrado";
            string another = "\" \u2742";
            string quero = "Quadrado";
            string adeus = "Adeus";

            double xx = 1.23456;
            int ii = 19;

            Console.WriteLine(quadrado);
            Console.WriteLine(another);
            Console.WriteLine($"Ado À Ado cada um no seu {quero}");
            Console.WriteLine("Olá" + adeus);
            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");
            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");
        }
    }
}

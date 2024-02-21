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

            Console.WriteLine(quadrado);
            Console.WriteLine(another);
            Console.WriteLine($"Ado À Ado cada um no seu {quero}");
            Console.WriteLine("Olá" + adeus);
        }
    }
}

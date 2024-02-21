using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string quadrado = "Ado A Ado cada um no seu quadrado";
            string another = "\" \u2742";

            Console.WriteLine(quadrado);
            Console.WriteLine(another);
        }
    }
}

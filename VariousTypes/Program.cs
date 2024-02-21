using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            uint y = 23U;
            long w = 3L;
            ulong q = 14UL;

            char uni = '\u2605';

            double t = 3.141516;

            bool f = false;

            Console.WriteLine($"{x}, {y}, {w}, {q}");
            Console.WriteLine(uni);
            Console.WriteLine(t);
            Console.WriteLine(f);
        }
    }
}

using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            float result = 0;

            Console.WriteLine("Insert a Integer:\n");
            string str1 = Console.ReadLine();
            int i = int.Parse(str1);
            Console.WriteLine("Insert a Real number:\n");
            string str2 = Console.ReadLine();
            float w = float.Parse(str2);

            result = i + w;
            Console.WriteLine(result);
        }
    }
}

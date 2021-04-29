using System;

namespace Wetvi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите cлово: ");
            string st = Console.ReadLine();
            if (st=="Hello")
            {
                Console.WriteLine($"Привет {st}");
            }
            else
            {
                Console.WriteLine($"Goog bay {st}");
            }

            Console.ReadKey();

        }
    }
}

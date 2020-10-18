using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int [20];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = rand.Next(20);
            }
            foreach(int item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Array.Clear(arr, 0, 10);
            foreach (int item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = -1;
                }
            }
            foreach (int item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Max_min_numberarr
{
    class Numarr
    {
        int[] arr = new int[20];
        Random ran = new Random();
        Mutex mu = new Mutex();
        public void Print()
        {
            mu.WaitOne();
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = ran.Next(-100, 100);
                Console.Write(arr[i]+",");
                
            }
            Console.WriteLine();
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId}");
            mu.ReleaseMutex();
        }
        public void Maxnum()
        {
            mu.WaitOne();
                Array.Sort(arr);
                int maxval = arr[arr.Length - 1];
                Console.WriteLine($"Max value {maxval}");
                Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId}");
            mu.ReleaseMutex();
        }
        public void Minnum()
        {
            int minval = arr.Min<int>();
            Console.WriteLine($"Min value {minval}");
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId}");
        }

    }
}

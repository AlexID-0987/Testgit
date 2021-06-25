using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mutex_random_arrs
{
    class Arrvalues
    {
        Random ra = new Random();
        Random r = new Random();
        int[] arr = new int[20];
        Mutex mu = new Mutex();
        
        public void Print()
        {
            var t = new Stopwatch();
            t.Start();
            mu.WaitOne();
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = ra.Next(-100, 100);
                Console.WriteLine($"\t{arr[i]}");
                Console.WriteLine($"\t\tThread{Thread.CurrentThread.ManagedThreadId}");
                
            }
            mu.ReleaseMutex();
            t.Stop();
            Console.WriteLine($"Time one arr {t.Elapsed}");

        }
        public void Printarr()
        {
            var n = new Stopwatch();
            n.Start();
            mu.WaitOne();
            for(int i=0;i<arr.Length;i++)
            {
                
                arr[i] = ra.Next(-100, 100) + r.Next(1, 20);
                Console.WriteLine($"\t\t\t{arr[i]}");
                arr[i] = ra.Next(-200, 50);
                Console.WriteLine(arr[i]);
                Console.WriteLine($"\tThread{Thread.CurrentThread.ManagedThreadId}");
            }
            mu.ReleaseMutex();
            n.Stop();
            Console.WriteLine($"\t\ttime two arr {n.Elapsed}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace funkcionmutex
{
    class Numbercl
    {
        public int x = 0;
        
        
        public void Counted()
        {
            var ti = new Stopwatch();
            ti.Start();
            
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine($"\tthread{Thread.CurrentThread.ManagedThreadId}");
            }
            
            Console.WriteLine($"time { ti.Elapsed}");
            
            Console.WriteLine();
        }
        public void Countnum()
        {
            
            var ti1 = new Stopwatch();
            ti1.Start();
            for (int i = 21; i > 0; i--)
            {
                Console.WriteLine(i);
                
                Console.WriteLine($"\t\t\ttread{Thread.CurrentThread.ManagedThreadId}");
            }
            Thread.Sleep(400);
            ti1.Stop();
            Console.WriteLine($"time 2 {ti1.Elapsed}");
            
            
        }
        public void Mult()
        {
            Mutex mut = new Mutex();
            for (int i=0;i<30;i++)
            {
                mut.WaitOne();
                Console.WriteLine($"\tMutex start{i * 2}");
                mut.ReleaseMutex();
            }
        }
    }
}

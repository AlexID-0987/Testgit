using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace funkcionmutex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Numbercl num = new Numbercl();
            num.Counted();
            Thread tred = new Thread(num.Countnum);
            tred.Start();
            num.Mult();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mutex_random_arrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrvalues a = new Arrvalues();
            
            Thread t = new Thread(a.Print);
            t.Start();
            Thread t1 = new Thread(a.Printarr);
            t1.Start();
        }
    }
}

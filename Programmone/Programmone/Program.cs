using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programmone
{
    class Program
    {
        static void Main(string[] args)
        {
            Number nu = new Number();
            nu.Print();
            Mutex mut = null;
            if(Mutex.TryOpenExisting("mut",out mut))
            {
                Console.WriteLine("Приложeнение запущенно");
                Environment.Exit(0);
            }
            mut = new Mutex(false, "mut");
            Console.WriteLine("Print");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Max_min_numberarr
{
    class Program
    {
        static void Main(string[] args)
        {
            Numarr nu = new Numarr();
            Thread tr = new Thread(nu.Print);
            Thread ma = new Thread(nu.Maxnum);
            tr.Start();
            ma.Start();
            nu.Minnum();
        }
    }
}

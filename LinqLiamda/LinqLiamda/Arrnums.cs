using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqLiamda
{
    class Arrnums
    {
        int[] num = { 2234, 876, 457, 5, 567, 234 };
        public void Iter()
        {
            var squaredNumbers = num.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));
        }
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayListFor
{
    class Arr
    {
        ArrayList col = new ArrayList() { "den", 23, 56, 78, 990, "work" };
        public void Print()
        {
            foreach(var colec in col )
            {
                Console.WriteLine(colec);
            }
        }
    }
}

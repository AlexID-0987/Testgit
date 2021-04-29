using System;
using System.Collections.Generic;
using System.Text;

namespace Mainstring
{
    class TwoString
    {
        string[] stringsTwo = { "aaa", "bbb", "ccc" };

        public void Print()
        {
            

            foreach (var s in stringsTwo) Console.Write(s + " ");
        }
    }
}

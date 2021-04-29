using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mainstring
{
    class FirstString
    {
        string [] stringsFirst ={"aaa", "bbb", "ccc"};
        

        public void Linq()
        {
            string result = stringsFirst.Aggregate((result, next)=>result+" "+next);
            Console.WriteLine(result);
        }
            

           
    }
}

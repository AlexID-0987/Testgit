using System;
using System.Collections.Generic;
using System.Text;

namespace Formatstring
{
    class CompoString
    {
        public string ObjectName { get; set; }
        public int Value { get; set; }

       
        public void Override()=> Console.WriteLine($"{ObjectName,-5},{ Value}");
        
        
    }
}

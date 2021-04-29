using System;
using System.Collections.Generic;
using System.Text;

namespace Lengthstring
{
    class StringBuld
    {
        StringBuilder sb = new StringBuilder("Доброе утро!");
        public void St()
        {
            Console.WriteLine(sb);
        }
        public void Leng()
        {
            Console.WriteLine($"Длина строки: {sb.Length}");
        }
        public void Cap()
        {
            Console.WriteLine($"Емкость строки: {sb.Capacity}");
        }
        public void Ins()
        {
            sb.Insert(11, " Oleg");
            Console.WriteLine($"{sb}");
            Console.WriteLine($"{sb.Capacity}");
        }
    }
}

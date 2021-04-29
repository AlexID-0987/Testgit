using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrakcia
{
    class Cat:Izoo
    {
        public int IdCat { get; set; } = 1;
        public string NameCat { get; set; } = "Tom";
        public string InfoCat { get; set; } = "Cat Tom does not like a dog Dik";

        public void Show()
        {
            Console.WriteLine($"{IdCat,-5}{NameCat,-5}{InfoCat}");
        }
        public void Tipinfo()
        {
            Console.WriteLine($"Cat a not Dog, cat love milk");
        }
    }
}

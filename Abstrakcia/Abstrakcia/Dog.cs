using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrakcia
{
    class Dog:Izoo
    {
        public int IdDog { get; set; } = 345;
        public string DogName { get; set; } = "Dic";
        public string InfoDog { get; set; } = "Dic to love cat";

        public void ShowDog()
        {
            Console.WriteLine($"{IdDog,-5}{DogName,-5}{InfoDog}");
        }
        public void Tipinfo()
        {
            Console.WriteLine($"Dog not cat,dog loves meat");
        }
    }
}

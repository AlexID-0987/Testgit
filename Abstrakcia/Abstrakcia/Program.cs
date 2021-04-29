using System;

namespace Abstrakcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.Show();
            cat.Tipinfo();
            dog.ShowDog();
            dog.Tipinfo();
        }
    }
}

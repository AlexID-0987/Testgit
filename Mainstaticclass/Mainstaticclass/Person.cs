using System;
using System.Collections.Generic;
using System.Text;

namespace Mainstaticclass
{
    static class Person
    {
        public static string Name { get; set; } = "Alex";
        public static int Age { get; set; } = 30;

        public static void Info()
        {
            Console.WriteLine($"{Name},{Age}");
        }
        public static void Sum()
        {
            Console.WriteLine($"{Name + "Jlda"}");
        }
        //Когда нам небходимо сохранить класс и его поля неизменными в глобальном и многосточном 
        //проекте, т.к. статический класс не позволяет  создавать экземпляр класса то за поля класса мы можем быть спокойны.
        //Если содержимые поля класса в проекте будут подверженны изменению то использование статического класса
        // не имеет смысла.
    
    }
}

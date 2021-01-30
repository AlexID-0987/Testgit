using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Himikal:Products,ICombustible
    {
        public Himikal(string type, string quantity) : base(type, quantity)
        { }
        public override string ToString()
        {
            return $"Himikal producks \t{base.ToString().Substring(base.ToString().IndexOf("\t") + 1)}";
        }
        public void Combustible()
        {
            Console.WriteLine($"Products {Type}-{Quantity} is danger!");
        }
    }
}

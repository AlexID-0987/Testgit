using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Food:Products,IPerishable
    {
        public Food (string type,string quantity):base (type, quantity)
        { }
        public override string ToString()
        {
            return $"Food\t{base.ToString().Substring(base.ToString().IndexOf("\t")+1)}";
        }
        public void Perishable()
        {
            Console.WriteLine($"Products {Type}-{Quantity} is perishable!");
        }
    }
}

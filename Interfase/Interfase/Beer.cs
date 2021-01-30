using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Beer:Products,IAlcoholic
    {
        public Beer(string type, string quantity) : base(type, quantity)
        { }
        public override string ToString()
        {
            return $"Beer\t{base.ToString().Substring(base.ToString().IndexOf("\t") + 1)}";
        }
        public void Alcoholic()
        {
            Console.WriteLine($"Products Beer {Type}-{Quantity} from the elite spirits department!");
        }
    }
}

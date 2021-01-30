using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Services:Products,ICombustible
    {
        public Services(string type, string quantity) : base(type, quantity)
        { }
        public override string ToString()
        {
            return $"Common consumption goods \t{base.ToString().Substring(base.ToString().IndexOf("\t") + 1)}";
        }
        public void Combustible()
        {
            Console.WriteLine($"Plate {Type}-{Quantity} is crashed!");
        }
    }
}

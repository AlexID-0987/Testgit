using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Products
    {
        public string Type { get; set; }
        public string Quantity { get; set; }
        public Products(string type,string quantity)
        {
            Type = type;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"Products\t Type = {Type}, Quantity = {Quantity}";
        }
    }
}

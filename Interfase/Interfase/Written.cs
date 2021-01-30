using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Written
    {
        public string Name { set; get; }
        public string Quantity { set; get; }
        public Written(string name, string quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Products\t Type = {Name}, Quantity = {Quantity}";
        }

    }
}

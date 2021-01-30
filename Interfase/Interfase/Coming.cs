using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Coming
    {
        public string  Type { get; set; }
        public string Quantity { get; set; }
        
        
        public Coming(string type, string quantity)
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

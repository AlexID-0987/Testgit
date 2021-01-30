using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Sales
    {
        public string Name { set; get; }
        public string Quantity { set; get; }
        public string Date { set; get; }
        public Sales (string name,string quan,string date)
        {
            Name = name;
            Quantity = quan;
            Date = date;
        }
        public override string ToString()
        {
            return $"Products sales:\t Products = {Name}, Quantity = {Quantity},Date={Date}";
        }
        
    }
}

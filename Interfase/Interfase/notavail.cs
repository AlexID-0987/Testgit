﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Notavail:Products,INot
    {
        public Notavail(string type, string quantity) : base(type, quantity)
        { }
        public override string ToString()
        {
            return $"Product \t{base.ToString().Substring(base.ToString().IndexOf("\t") + 1)}";
        }
        public void Not()
        {
            Console.WriteLine($"Products  {Type}-{Quantity} not in shops!");
        }
    }
}

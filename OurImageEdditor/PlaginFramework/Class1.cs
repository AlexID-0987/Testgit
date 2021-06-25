using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PlaginFramework
{
    public interface Filter
    {
        Image MyPlugin(Image src);
        string Name { get; }
    }
}

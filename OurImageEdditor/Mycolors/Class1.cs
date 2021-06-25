using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaginFramework;
using System.Drawing;

namespace Mycolors
{
    public class Class1 : Filter
    {
        public string Name => "Make Red";

        public Image MyPlugin(Image src)
        {
            var bitmap = new Bitmap(src);
            for(int row=0;row<bitmap.Height;row++)
            {
                for (int col=0;col<bitmap.Width;col++)
                {
                    Color color = bitmap.GetPixel(col, row);
                    if(color.R>0)
                    {
                        color = Color.FromArgb(color.A, 255, color.G, color.B);
                    }
                    bitmap.SetPixel(col, row, color);

                }
            }
            return bitmap;
        }
    }
    public class Class2 : Filter
    {
        public string Name => "Make Green";

        public Image MyPlugin(Image src)
        {
            var bitmap1 = new Bitmap(src);
            for (int row = 0; row < bitmap1.Height; row++)
            {
                for (int col = 0; col < bitmap1.Width; col++)
                {
                    Color color = bitmap1.GetPixel(col, row);
                    if (color.R > 0)
                    {
                        color = Color.FromArgb(color.A, color.G,204, color.B);
                    }
                    bitmap1.SetPixel(col, row, color);

                }
            }
            return bitmap1;
        }
    }
    public class Myblue : Filter
    {
        public string Name => "Make Blue";

        public Image MyPlugin(Image src)
        {
            var bitmap1 = new Bitmap(src);
            for (int row = 0; row < bitmap1.Height; row++)
            {
                for (int col = 0; col < bitmap1.Width; col++)
                {
                    Color color = bitmap1.GetPixel(col, row);
                    if (color.R > 0)
                    {
                        color = Color.FromArgb(color.A, color.G, color.B, 223);
                    }
                    bitmap1.SetPixel(col, row, color);

                }
            }
            return bitmap1;
        }
    }
}

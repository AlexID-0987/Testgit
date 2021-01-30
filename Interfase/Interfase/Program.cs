using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Products a = new Products("Perishable", "236");
            Console.WriteLine(a);
            Food c = new Food("Milk", "10 lit");
            Console.WriteLine(c);
            IPerishable b = new Food("Bread", "134");
            Console.WriteLine(b);
            b.Perishable();
            Himikal d = new Himikal("Salute", "569");
            Console.WriteLine(d);
            d.Combustible();
            ICombustible q = new Himikal("Lighter", "456");
            Console.WriteLine(q);
            Services w = new Services("Cap", "137");
            Console.WriteLine(w);
            ICombustible e = new Services("Sauce bowl", "2");
            Console.WriteLine(e);
            e.Combustible();
            Beer r = new Beer("Tuborg", "1 liter");
            Console.WriteLine(r);
            IAlcoholic t = new Beer("Miller", "124p");
            Console.WriteLine(t);
            t.Alcoholic();
            Coming z = new Coming("Oil", "123");
            Console.WriteLine(z);
            Coming x = new Coming("Poteuto", "445");
            Console.WriteLine(x);
            Console.WriteLine();
            List<Coming> coming = new List<Coming>(10);
            coming.Add(new Coming("Rewo", "122"));
            coming.Add(new Coming("Tomato", "34"));
            coming.Add(new Coming("Peper", "12"));
            foreach (Coming ytr in coming)
            {
                Console.WriteLine(ytr);
                



            }

            Console.Write("Enter product add - ");
            string tmp = Console.ReadLine();
            Console.Write("Enter product add - ");
            string tmp1 = Console.ReadLine();
            Console.WriteLine($"Product {tmp},{tmp1}");
            coming.Add(new Coming(tmp,tmp1));
            foreach (Coming sew in coming)
            {
                Console.WriteLine(sew);
            }
            List<Sales> sales = new List<Sales>();
            sales.Add(new Sales("Water", "30 lit", "12-12-2020"));
            Console.Write("Enter product sales 1 - ");
            string srt = Console.ReadLine();
            Console.Write("Enter quantity sales 1 - ");
            string srt1 = Console.ReadLine();
            Console.Write("Enter date sales 1 - ");
            string srt2 = Console.ReadLine();
           
            sales.Add(new Sales(srt, srt1, srt2));


            foreach (Sales srt4 in sales)
            {
                Console.WriteLine(srt4);
            }
            List<Written> written = new List<Written>();
            written.Add(new Written("Water", "12"));
            Console.Write("Enter product written off 1 - ");
            string st = Console.ReadLine();
            string off = "Cola";
            Console.Write("Enter quantity written off 1 - ");
            string st1 = Console.ReadLine();
            foreach (Written st2 in written)
            {
                Console.WriteLine(st2);
            }
            if(off==st)
            {
                Console.WriteLine($"Products not written!" + st);
            }
            foreach (Written st3 in written)
            {
                Console.WriteLine(st3);
            }
            INot y = new Notavail("Apple", "34,6");
            Console.WriteLine(y);
            y.Not();
            Console.WriteLine();
            INot k = new Suitability("Milk", "129");
            Console.WriteLine(k);
            k.Not();
            INot m = new Defective("Fish", "43");
            Console.WriteLine(m);
            m.Not();



        }
    }
}

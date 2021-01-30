using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class List
    {
        ArrayList Collect = new ArrayList();
        ArrayList Coll = new ArrayList();
         



        public void Add()
        {
            Console.WriteLine("\tAdd:");
            Collect.Add("\tHann Barew 34");
            Collect.Add("\tAlex Bimop 27");
            Collect.Add("\tBred Sher 45");
            foreach(var item in Collect)
            {
                Console.WriteLine($"Person => {item}");
            }

        }
        public void Insert()
        {
            Console.WriteLine($"\n\tInsert List:");
            Console.WriteLine();
            Collect.Insert(2,"\tJoann Frid 80");
            Collect.Insert(4,"\tHelli Sert 56");
            Collect.Insert(5,"\tBred Pit 42.5");
            foreach (var i in Collect)
            {
                Console.WriteLine($"Persone => {i}");
            }

        }
        public void InsertRange()
        {
            Coll.Add("\tRed Bull 26");
            Coll.Add("\tHann Klit 63");
            Coll.Add("\tLin Hi 43");
            Console.WriteLine($"\n\tInsert Range:");
            Console.WriteLine();
            Collect.InsertRange(3, Coll);
            
            foreach (var a in Collect)
            {
                Console.WriteLine($"Persone => {a}");
            }

        }
        public void Remove()
        {
            Console.WriteLine("\tRemove:");
            Collect.RemoveAt(2);
            
            foreach (var b in Collect)
            {
                Console.WriteLine($"Person => {b}");
            }

        }
        public void Removerange()
        {
            Console.WriteLine("\tRemove range:");
            Collect.RemoveRange(4,3);

            foreach (var c in Collect)
            {
                Console.WriteLine($"Person => {c}");
            }

        }
    }
}

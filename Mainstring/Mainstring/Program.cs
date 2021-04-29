using System;
using System.Text;

namespace Mainstring
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringsOne = new[] { "aaa", "bbb", "ccc" };
            var sb = new StringBuilder();
            foreach (var s in stringsOne)
            {
                sb.Append(s + " ");
            }
            var concat = sb.ToString();

            Console.WriteLine(concat.Substring(0, concat.Length - 1));
            Console.ReadKey();


            FirstString F = new FirstString();
            F.Linq();
            TwoString T = new TwoString();
            T.Print();
        }
    }
}

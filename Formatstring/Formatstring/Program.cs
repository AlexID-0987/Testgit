using System;

namespace Formatstring
{
    class Program
    {
        static void Main(string[] args)
        {
            CompoString C = new CompoString();
            CompoString F = new CompoString();
            CompoString D = new CompoString();
            C.ObjectName = "Deni";
            C.Value = 123;
            F.ObjectName = "Rew";
            F.Value = 546;
            D.ObjectName = "Tyna";
            D.Value = 3429;
            C.Override();
            F.Override();
            D.Override();
        }
    }
}

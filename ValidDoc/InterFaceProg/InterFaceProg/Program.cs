using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IParInter<int> a1 = new Inherit<int>();

            int a = a1.Add(2, 3);
            int b = a1.Sub(7, 3);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}

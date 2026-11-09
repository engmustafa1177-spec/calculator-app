using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App");
            Console.WriteLine("2 + 3 = " + add(2, 3));
            Console.ReadKey();
        }
    }
}

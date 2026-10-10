using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    internal class Program
    {
        static int Maximum(ref int a, ref  int b)
        {
            
            
            return Math.Max(a, b);
            
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}, {b}");
            
            Maximum(ref a, ref b);
            Console.WriteLine(Maximum(ref a, ref b));
            
        }
    }
}

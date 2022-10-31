using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Sub_Mul_Div
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}+{1}={2}",a,b, a+b);
            Console.WriteLine("{0}-{1}={2}",a, b,a-b);
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            Console.ReadLine();
        }
    }
}

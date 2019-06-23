using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
            Console.WriteLine("Floor" + Math.Floor(15.3));

            int num1 = 13;
            int num2 = 9;
            Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, Math.Min(num1,num2));

            Console.ReadLine();
        }
    }
}

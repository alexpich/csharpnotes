using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes__Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Human alex = new Human("alex", "p");

            alex.IntroduceYourself();

            Console.ReadKey();
        }
    }
}

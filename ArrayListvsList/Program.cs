using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListvsList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array: immutable - limited to one type
            int[] scores = new int[] { 1, 2, 3, 4, 5 };

            // List - limited to only one type
            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(15);
            list.Sort();
            list.RemoveRange(2, 2);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Contains(4));

            int index = list.FindIndex(x => x == 4);
            Console.WriteLine(list[index]);

            list.RemoveAt(index);

            list.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("\n\n");

            // ArrayList - can contain various types
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add("3");
            arrayList.Add(new Number { n = 4 });

            foreach (Object o in arrayList)
            {
                Console.WriteLine(o);
            }
            Console.ReadLine();
        }
    }

    class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }
}

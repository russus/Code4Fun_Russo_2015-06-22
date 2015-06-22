using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code5fun_russo_2015_06_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 14, 7, 20, 33 };
            int[] b = { 1, 32, 51, 7, 99 };
            int[] c = { 82, 55, 78, 92, 12, 44, 51 };
            LinkedList<int> ll = new LinkedList<int>(c);
            Exercise ex = new Exercise();
            int[] i = ex.Intersection(a, b);
            int x = ex.getElementAt(ll, 5);

            Console.WriteLine("Excercise A: " + printArray(i));
            Console.WriteLine("Excercise B: " + x);
            Console.ReadKey();
        }

        private static string printArray(int[] i)
        {
            string values = "{";
            foreach (int x in i)
            {
                values += x + ",";
            }

            return values.Substring(0, values.Length -1) + "}";
        }
    }
}

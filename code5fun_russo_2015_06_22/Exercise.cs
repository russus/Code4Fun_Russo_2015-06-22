using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code5fun_russo_2015_06_22
{
    public class Exercise
    {
        public Exercise() { }


        public int[] Intersection(int[] a, int[] b)
        {
            if (a == null) throw new ArgumentNullException();
            if (b == null) throw new ArgumentNullException();
            return a.Intersect(b).ToArray();
        }

        public int getElementAt(LinkedList<int> elements, int index)
        {
            if (index <= 0) throw new ArgumentOutOfRangeException();
            if (elements == null) throw new ArgumentNullException();
            try
            {
                //return elements.Reverse().Take(index).Last();
                return elements.Reverse().ElementAt(index -1);
            }
            catch (ArgumentOutOfRangeException ex) { throw new ArgumentOutOfRangeException(); }
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using code5fun_russo_2015_06_22;
using System.Collections.Generic;

namespace code5fun_russo_2015_06_22_unit
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethodA()
        {
            try
            {
                Exercise ex = new Exercise();
                int[] a = { 1, 14, 7, 20, 33 };
                int[] b = { 1, 32, 51, 7, 99 };
                int[] i = ex.Intersection(a, b);
                int[] expected = { 1, 7 };

                NUnit.Framework.Assert.AreEqual(expected, i, "Error, arrays are not equal.");
            }
            catch (ArgumentNullException ex)
            {
                NUnit.Framework.Assert.Fail("arrays can not be null.");
            }
        }

        [Test]
        public void TestMethodB()
        {
            try
            {
                Exercise ex = new Exercise();
                int[] c = { 82, 55, 78, 92, 12, 44, 51 };
                LinkedList<int> ll = new LinkedList<int>(c);
                int x = ex.getElementAt(ll, 5);
                int expected = 78;

                NUnit.Framework.Assert.AreEqual(expected, x);

            }
            catch (ArgumentNullException nue)
            {
                NUnit.Framework.Assert.Fail("array can not be null");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                NUnit.Framework.Assert.Fail("index out of bound exception");
            }
        }
    }
}

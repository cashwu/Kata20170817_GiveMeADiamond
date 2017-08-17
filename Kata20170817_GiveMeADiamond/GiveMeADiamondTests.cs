using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170817_GiveMeADiamond
{
    [TestClass]
    public class GiveMeADiamondTests
    {
        [TestMethod]
        public void input_1_diamond()
        {
            DiamondPrintShouldBe("*\n", 1);
        }

        [TestMethod]
        public void input_2_diamond()
        {
            DiamondPrintShouldBe(null, 2);
        }

        [TestMethod]
        public void input_n1_diamond()
        {
            DiamondPrintShouldBe(null, -1);
        }

        [TestMethod]
        public void input_3_diamond()
        {
            DiamondPrintShouldBe(" *\n***\n *\n", 3);
        }

        private static void DiamondPrintShouldBe(string expected, int count)
        {
            var diamond = new Diamond();
            var actual = diamond.print(count);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Diamond
    {
        public string print(int n)
        {
            if (n % 2 == 0 || n < 0)
            {
                return null;
            }

            var result = new List<string>();
            var center = n * 1.0 / 2;
            for (int i = 1; i <= center; i++)
            {
                result.Insert(i - 1, Item(i));
                result.Insert(i, Item(i));
            }
            result.Insert((int)center, new string('*', n) + "\n");

            return string.Concat(result);
        }

        private static string Item(int i)
        {
            return new string(' ', i) + new string('*', i * 2 -1) + "\n";
        }
    }
}

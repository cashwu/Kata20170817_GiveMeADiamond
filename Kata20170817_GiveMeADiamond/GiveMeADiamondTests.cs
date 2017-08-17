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

        [TestMethod]
        public void input_5_diamond()
        {
            DiamondPrintShouldBe("  *\n ***\n*****\n ***\n  *\n", 5);
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
            var center = (int)(n * 1.0 / 2);
            for (int i = 1; i <= center; i++)
            {
                result.Insert(i - 1, Item(i, n));
                result.Insert(i, Item(i, n));
            }
            result.Insert(center, new string('*', n) + "\n");

            return string.Concat(result);
        }

        private static string Item(int i, int n)
        {
            return new string(' ', (n - i) / 2) + new string('*', i * 2 - 1) + "\n";
        }
    }
}

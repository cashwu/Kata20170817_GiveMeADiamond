using System;
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
            if (n % 2 == 0)
            {
                return null;
            }
            return "*\n";
        }
    }
}

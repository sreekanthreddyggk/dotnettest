using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.WiTronix.Business.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Test_Method()
        {
            CaluclateBusiness cB = new CaluclateBusiness();
            int value1 = 10;
            int value2 = 5;

            Assert.AreEqual(15, cB.Add(value1, value2));
        }

        [TestMethod]
        public void Sub_Test_Method1()
        {
            CaluclateBusiness cB = new CaluclateBusiness();
            int value1 = 10;
            int value2 = 5;

            Assert.AreNotEqual(15, cB.Sub(value1, value2));
        }

        [TestMethod]
        public void Sub_Test_Method2()
        {
            CaluclateBusiness cB = new CaluclateBusiness();
            int value1 = 10;
            int value2 = 5;

            Assert.AreEqual(5, cB.Sub(value1, value2));
        }
    }
}

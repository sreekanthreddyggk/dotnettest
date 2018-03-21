using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.WiTronix.DataAccess.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Test_Method()
        {
            CaluclateDataAccess cDA = new CaluclateDataAccess();
            int value1 = 10;
            int value2 = 5;
           
            Assert.AreEqual(15, cDA.Add(value1, value2));
        }

        [TestMethod]
        public void Sub_Test_Method1()
        {
            CaluclateDataAccess cDA = new CaluclateDataAccess();
            int value1 = 10;
            int value2 = 5;

            Assert.AreNotEqual(15, cDA.Sub(value1, value2));
        }

        [TestMethod]
        public void Sub_Test_Method2()
        {
            CaluclateDataAccess cDA = new CaluclateDataAccess();
            int value1 = 10;
            int value2 = 5;

            Assert.AreEqual(5, cDA.Sub(value1, value2));
        }

    }
}

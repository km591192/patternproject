using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using krgt;

namespace TestProject1
{
    [TestClass]
    public class Test2
    {
        [TestMethod]
        public void TestMethod6()
        {
            Beverage teawithlemon = new Lemon(new Tea());
            double total = 0;
            total = teawithlemon.cost();
            Assert.AreEqual(total, 2.5);
            Assert.IsNotNull(total);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Beverage tea = new Tea();
            double total = 0;
            total = tea.cost();
            Assert.AreEqual(total, 2);
            Assert.IsNotNull(total);
        }

     

    }
}

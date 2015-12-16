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
        [TestMethod]
        public void TestMethod8()
        {
            Beverage chicksal = new ChickenSalatwithsauce(new ChickenSalat());
            double total = 0;
            total = chicksal.cost();
            Assert.AreEqual(total, 6.5);
            Assert.IsNotNull(total);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Beverage beefsal = new BeefSalatwithsauce(new BeefSalat());
            double total = 0;
            total = beefsal.cost();
            Assert.AreEqual(total, 6);
            Assert.IsNotNull(total);
        }
        [TestMethod]
        public void TestMethod10()
        {
            Beverage fishsal = new FishSalatwithsauce(new FishSalat());
            double total = 0;
            total = fishsal.cost();
            Assert.AreEqual(total, 5);
            Assert.IsNotNull(total);
        }

     

    }
}

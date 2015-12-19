using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using krgt;

namespace TestProject1
{

    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Food chicken = new Chicken();
            Food fried = new Fried();
            Food sodawater = new SodaWater();

            double d = fried.cost() + chicken.cost() + sodawater.cost();
            Facade facade = new Facade();
            double db = facade.ChickenMenu(d);
            Assert.AreEqual(db,6.75);
            Assert.IsNotNull(d);
            Assert.IsNotNull(db);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Food beef = new Beef();
            Food fried = new Fried();
            Food sodawater = new SodaWater();

            double tr = fried.cost() + beef.cost() + sodawater.cost();
            Facade facade1 = new Facade();
            double tr1 = facade1.BeefMenu(tr);
            Assert.AreEqual(tr1, 7.2);
            Assert.IsNotNull(tr);
            Assert.IsNotNull(tr1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Food fish = new Fish();
            Food fried = new Fried();
            Food sodawater = new SodaWater();

            double tr = fried.cost() + fish.cost() + sodawater.cost();
            Facade facade1 = new Facade();
            double tr1 = facade1.BeefMenu(tr);
            Assert.AreEqual(tr1, 7.2);
            Assert.IsNotNull(tr);
            Assert.IsNotNull(tr1);
        }


        [TestMethod]
        public void TestMethod4()
        {
            Food tea = new Tea();
            Food cake = new Cake();

            double tr = cake.cost() + tea.cost();
            Facade facade1 = new Facade();
            double tr1 = facade1.SweetCakeMenu(tr);
            Assert.AreEqual(tr1, 2.975);
            Assert.IsNotNull(tr);
            Assert.IsNotNull(tr1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Food tea = new Tea();
            Food pie = new Pie();

            double tr = pie.cost() + tea.cost();
            Facade facade1 = new Facade();
            double tr1 = facade1.SweetPieMenu(tr);
            Assert.AreEqual(tr1, 2.975);
            Assert.IsNotNull(tr);
            Assert.IsNotNull(tr1);
        }

    }

    [TestClass]
    public class Test2
    {
        [TestMethod]
        public void TestMethod6()
        {
            Food teawithlemon = new Lemon(new Tea());
            double total = 0;
            total = teawithlemon.cost();
            Assert.AreEqual(total, 2.5);
            Assert.IsNotNull(total);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Food tea = new Tea();
            double total = 0;
            total = tea.cost();
            Assert.AreEqual(total, 2);
            Assert.IsNotNull(total);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Food chicksal = new ChickenSalatwithsauce(new ChickenSalat());
            double total = 0;
            total = chicksal.cost();
            Assert.AreEqual(total, 6.5);
            Assert.IsNotNull(total);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Food beefsal = new BeefSalatwithsauce(new BeefSalat());
            double total = 0;
            total = beefsal.cost();
            Assert.AreEqual(total, 6);
            Assert.IsNotNull(total);
        }
        [TestMethod]
        public void TestMethod10()
        {
            Food fishsal = new FishSalatwithsauce(new FishSalat());
            double total = 0;
            total = fishsal.cost();
            Assert.AreEqual(total, 5);
            Assert.IsNotNull(total);
        }
    }


    [TestClass]
    public class Test3
    {
        [TestMethod]
        public void TestMethod11()
        {
            Worker worker = new Worker("Tom", 3);
            Supervisor supervisor = new Supervisor("Mary", 6);
            Assert.IsNotInstanceOfType(worker.GetType(), typeof(Supervisor));
            List<IEmployee> subordinate = new List<IEmployee>();
            subordinate.Add(worker);
            supervisor.AddSubordinate(worker);
            Assert.IsNotNull(subordinate[0]);
        }

        [TestMethod]
        public void TestMethod12()
        {
            Worker worker = new Worker("Tom", 3);
            Supervisor supervisor = new Supervisor("Mary", 6);
            Assert.IsNotInstanceOfType(worker.GetType(), typeof(Supervisor));
            List<IEmployee> subordinate = new List<IEmployee>();
            subordinate.Add(worker);
            supervisor.AddSubordinate(worker);
            Assert.IsNotNull(subordinate[0]);
            Assert.AreEqual(subordinate[0], worker);

            Worker w = new Worker("Jimm", 7);
            Supervisor s = new Supervisor("Martin", 8);
            subordinate.Add(w);
            s.AddSubordinate(w);
            Assert.AreEqual(subordinate[1], w);
            Assert.IsNotNull(subordinate[1]);

        }
    }
}

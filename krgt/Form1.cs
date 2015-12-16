using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace krgt
{
    public partial class Form1 : Form
    {
        public double sumfacade = 0;
        public int[] levelworker = { 5, 8 };
        public int[] levelsup = { 6, 7, 9 };
        string[] nameworker = { "Worker Tom", "Worker Jimmy" };
        string[] namesup = { "Supervisor Mary", "Supervisor Jerry", "Supervisor Bob" };


        Facade facade = new Facade();
        Beverage icecream = new IceCream();
        Beverage cake = new Cake();
        Beverage pie = new Pie();
        Beverage fried = new Fried();
        Beverage chicken = new Chicken();
        Beverage beef = new Beef();
        Beverage fish = new Fish();
        Beverage cheesburger = new Cheesburger();
        Beverage gamburger = new Gamburger();
        Beverage chickensalat = new ChickenSalat();
        Beverage beefsalat = new BeefSalat();
        Beverage fishsalat = new FishSalat();
        Beverage sodawater = new SodaWater();
        Beverage water = new Water();
        Beverage tea = new Tea();
        Beverage coffee = new Coffee();

        Beverage coffeewithsyrop = new Syrop(new Coffee());
        Beverage coffeewithlemon = new Lemon(new Coffee());
        Beverage teawithlemon = new Lemon(new Tea());
        Beverage teawithhoney = new Honey(new Tea());
        Beverage fishsalatwithsauce = new FishSalatwithsauce(new FishSalat());
        Beverage beefsalatwithsauce = new BeefSalatwithsauce(new BeefSalat());
        Beverage chickensalatwithsauce = new ChickenSalatwithsauce(new ChickenSalat());
        Beverage friedwithsauce = new Friedwithsauce(new Fried());
        Beverage icecreamwithsauce = new IceCreamwithsauce(new IceCream());
        Beverage cakewithsauce = new Cakewithsauce(new Cake());


        public Form1()
        {
            InitializeComponent();

            int worker = 0;
            if (nameworker.Length > worker)
            {
                //    Worker a = new Worker(nameworker[worker], levelworker[worker]);
                lbworker.Items.Add(nameworker[worker] + "," + levelworker[worker]);
                worker++;
                //  Worker e = new Worker(nameworker[worker], levelworker[worker]);
                lbworker.Items.Add(nameworker[worker] + "," + levelworker[worker]);
                worker++;

            }
            int sup = 0;

            if (namesup.Length > sup)
            {
                //Supervisor b = new Supervisor(namesup[sup], levelsup[sup]);
                lbworker.Items.Add(namesup[sup] + "," + levelsup[sup]);
                sup++;
                //Supervisor c = new Supervisor(namesup[sup], levelsup[sup]);
                lbworker.Items.Add(namesup[sup] + "," + levelsup[sup]);
                sup++;
                //Supervisor d = new Supervisor(namesup[sup], levelsup[sup]);
                lbworker.Items.Add(namesup[sup] + "," + levelsup[sup]);
                sup++;
            }

            lborder.SelectionMode = SelectionMode.MultiExtended;
            lbsandwich.SelectionMode = SelectionMode.MultiExtended;
            lbpotato.SelectionMode = SelectionMode.MultiExtended;
            lbsalat.SelectionMode = SelectionMode.MultiExtended;
            lbdesert.SelectionMode = SelectionMode.MultiExtended;
            lbdrink.SelectionMode = SelectionMode.MultiExtended;
            lbdrinkbehavior.SelectionMode = SelectionMode.MultiExtended;
            lbdesertbehavior.SelectionMode = SelectionMode.MultiExtended;
            lbmainsauce.SelectionMode = SelectionMode.MultiExtended;
            lbmenu.SelectionMode = SelectionMode.MultiExtended;

            lbmenu.Items.Add("Chicken menu -- " + facade.ChickenMenu(sumfacade) + "$");
            lbmenu.Items.Add("Beef menu -- " + facade.BeefMenu(sumfacade) + "$");
            lbmenu.Items.Add("Fish menu -- " + facade.FishMenu(sumfacade) + "$");
            lbmenu.Items.Add("Tea + Pie menu -- " + facade.SweetPieMenu(sumfacade) + "$");
            lbmenu.Items.Add("Tea + Cake menu -- " + facade.SweetCakeMenu(sumfacade) + "$");

            xmlread(lbdesert, "", "prop1"); //ice cream
            xmlread(lbdesert, "", "prop2"); //cake
            xmlread(lbdesert, "", "prop3"); //pie

            xmlread(lbdesertbehavior, "", "prop4"); //caramel
            xmlread(lbdesertbehavior, "", "prop5"); // chocolate
            xmlread(lbdesertbehavior, "", "prop6"); // cakesauce

            xmlread(lbpotato, "", "prop7"); //fried

            xmlread(lbmainsauce, "", "prop8"); //potato sauce

            xmlread(lbsandwich, "", "chick"); //chicken
            xmlread(lbsandwich, "", "cheese"); //cheeseburger
            xmlread(lbsandwich, "", "beef"); // beef
            xmlread(lbsandwich, "", "fish"); //fish
            xmlread(lbsandwich, "", "gamb"); //gamburger

            xmlread(lbsalat, "", "chickensalat"); // chicken salat
            xmlread(lbsalat, "", "beefsalat"); //beef salat
            xmlread(lbsalat, "", "fishsalat"); // fish salat

            xmlread(lbmainsauce, "", "chickensalatsauce"); // chicken salat sauce
            xmlread(lbmainsauce, "", "beefsalatsauce"); //beef salat sauce
            xmlread(lbmainsauce, "", "fishsalatsauce"); // fish salat sauce

            xmlread(lbdrink, "", "sodawater"); //soda water
            xmlread(lbdrink, "", "water"); //mineral water
            xmlread(lbdrink, "", "tea"); //tea
            xmlread(lbdrink, "", "coffee"); //coffee

            xmlread(lbdrinkbehavior, "", "Honey"); //honey
            xmlread(lbdrinkbehavior, "", "Lemon"); //lemon
            xmlread(lbdrinkbehavior, "", "Syrop"); //syrop
        }



        private void xmlread(ListBox lb, string getnameditem, string childnote)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem(getnameditem);
                    if (attr != null)
                        lb.Items.Add(attr.Value);
                }
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - prop
                    if (childnode.Name == childnote)
                    {
                        lb.Items.Add(childnode.InnerText);
                    }
                }
            }

        }
        private void addlborder(ListBox lb, string s)
        {

            if (lb.Items.Count > 0)
                if (lb.SelectedItems.Count != 0)
                {
                    if (lb.SelectedItem.Equals(s))
                    {
                        lborder.Items.Add(s);
                    }
                }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            addlborder(lbsandwich, "Chicken sandwich");
            addlborder(lbsandwich, "Cheeseburger");
            addlborder(lbsandwich, "Gamburger");
            addlborder(lbsandwich, "Beef sandwich");
            addlborder(lbsandwich, "Fish sandwich");

            addlborder(lbpotato, "Fried");

            addlborder(lbmainsauce, "Potato + sauce");
            addlborder(lbmainsauce, "Fish salat + sauce");
            addlborder(lbmainsauce, "Beef salat + sauce");
            addlborder(lbmainsauce, "Chicken salat + sauce");

            addlborder(lbdesertbehavior, "Caramel + ice cream");
            addlborder(lbdesertbehavior, "Chocolate + ice cream");
            addlborder(lbdesertbehavior, "Cake + sauce");
            addlborder(lbdrinkbehavior, "Honey(Tea)");
            addlborder(lbdrinkbehavior, "Lemon");
            addlborder(lbdrinkbehavior, "Syrop(Coffee)");

            addlborder(lbsalat, "Fish salat");
            addlborder(lbsalat, "Beef salat");
            addlborder(lbsalat, "Chicken salat");

            addlborder(lbdesert, "Ice Cream");
            addlborder(lbdesert, "Cake");
            addlborder(lbdesert, "Pie");

            addlborder(lbdrink, "Mineral water");
            addlborder(lbdrink, "Tea");
            addlborder(lbdrink, "Coffee");
            addlborder(lbdrink, "Soda water");

            addlborder(lbmenu, "Chicken menu -- " + facade.ChickenMenu(sumfacade) + "$");
            addlborder(lbmenu, "Beef menu -- " + facade.BeefMenu(sumfacade) + "$");
            addlborder(lbmenu, "Fish menu -- " + facade.FishMenu(sumfacade) + "$");
            addlborder(lbmenu, "Tea + Pie menu -- " + facade.SweetPieMenu(sumfacade) + "$");
            addlborder(lbmenu, "Tea + Cake menu -- " + facade.SweetCakeMenu(sumfacade) + "$");



            if (lborder.Items.Count != 0)
            {
                string[] lines = new string[lborder.Items.Count];
                for (int i = 0; i < lborder.Items.Count; i++)
                    if (lborder.Items[i].ToString() != lines[i])
                        lines[i] = lborder.Items[i].ToString();
                lborder.Items.Clear();
                lborder.Items.AddRange(lines);
                lbsandwich.ClearSelected();
                lbpotato.ClearSelected();
                lbdesert.ClearSelected();
                lbdesertbehavior.ClearSelected();
                lbdrinkbehavior.ClearSelected();
                lbdrink.ClearSelected();
                lbsalat.ClearSelected();
                lbmenu.ClearSelected();
                lbmainsauce.ClearSelected();

            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            lborder.Items.Remove(lborder.SelectedItem);
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            double totalsum = 0;
            for (int i = 0; i < lborder.Items.Count; i++)
            {
                string s = lborder.Items[i].ToString();

                //salat
                if (s.Equals("Beef salat"))
                {
                    totalsum += beefsalat.cost();
                }
                if (s.Equals("Chicken salat"))
                    totalsum += chickensalat.cost();
                if (s.Equals("Fish salat"))
                    totalsum += fishsalat.cost();
                //salat + sauce
                if (s.Equals("Beef salat + sauce"))
                    totalsum += beefsalatwithsauce.cost();
                if (s.Equals("Chicken salat + sauce"))
                    totalsum += chickensalatwithsauce.cost();
                if (s.Equals("Fish salat + sauce"))
                    totalsum += fishsalatwithsauce.cost();

                if (s.Equals("Potato + sauce"))
                    totalsum += friedwithsauce.cost();

                if (s.Equals("Chicken sandwich"))
                    totalsum += chicken.cost();
                if (s.Equals("Cheeseburger"))
                    totalsum += cheesburger.cost();
                if (s.Equals("Gamburger"))
                    totalsum += gamburger.cost();
                if (s.Equals("Beef sandwich"))
                    totalsum += beef.cost();
                if (s.Equals("Fish sandwich"))
                    totalsum += fish.cost();

                if (s.Equals("Fried"))
                    totalsum += fried.cost();

                //econom menu
                if (s.Equals("Chicken menu -- " + facade.ChickenMenu(sumfacade) + "$"))
                    totalsum += facade.ChickenMenu(sumfacade);
                if (s.Equals("Beef menu -- " + facade.BeefMenu(sumfacade) + "$"))
                    totalsum += facade.BeefMenu(sumfacade);
                if (s.Equals("Fish menu -- " + facade.FishMenu(sumfacade) + "$"))
                    totalsum += facade.FishMenu(sumfacade);
                if (s.Equals("Tea + Pie menu -- " + facade.SweetPieMenu(sumfacade) + "$"))
                    totalsum += facade.SweetPieMenu(sumfacade);
                if (s.Equals("Tea + Cake menu -- " + facade.SweetCakeMenu(sumfacade) + "$"))
                    totalsum += facade.SweetCakeMenu(sumfacade);

                //desert
                if (s.Equals("Ice Cream"))
                    totalsum += icecream.cost();
                if (s.Equals("Pie"))
                    totalsum += pie.cost();
                if (s.Equals("Cake"))
                    totalsum += cake.cost();
                //desert+sauce
                if (s.Equals("Caramel + ice cream"))
                    totalsum += icecreamwithsauce.cost();
                if (s.Equals("Chocolate + ice cream"))
                    totalsum += icecreamwithsauce.cost();
                if (s.Equals("Cake + sauce"))
                    totalsum += cakewithsauce.cost();

                //drink
                if (s.Equals("Soda water"))
                    totalsum += sodawater.cost();
                if (s.Equals("Mineral water"))
                    totalsum += water.cost();
                if (s.Equals("Tea"))
                    totalsum += tea.cost();
                if (s.Equals("Coffee"))
                    totalsum += coffee.cost();
                //drink+..
                if (s.Equals("Honey(Tea)"))
                    totalsum += teawithhoney.cost();
                if (s.Equals("Syrop(Coffee)"))
                    totalsum += coffeewithsyrop.cost();
                if (s.Equals("Lemon"))
                    if (lborder.Items[i - 1].ToString().Equals("Tea"))
                        totalsum += teawithlemon.cost() - tea.cost();
                    else
                        if (lborder.Items[i - 1].ToString().Equals("Coffee"))
                            totalsum += coffeewithlemon.cost() - coffee.cost();
                        else totalsum += 1;

            }

            lborder.Items.Add("___________");
            lborder.Items.Add(totalsum + " $");
            totalsum = 0;

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int worker = 0, sup = 0;
            Worker a = new Worker(nameworker[worker], levelworker[worker]);
            worker++;
            Worker f = new Worker(nameworker[worker], levelworker[worker]);
            worker++;
            Supervisor b = new Supervisor(namesup[sup], levelsup[sup]);
            sup++;
            Supervisor c = new Supervisor(namesup[sup], levelsup[sup]);
            sup++;
            Supervisor d = new Supervisor(namesup[sup], levelsup[sup]);
            sup++;

            //set up the relationships
            b.AddSubordinate(a); //Tom works for Mary
            c.AddSubordinate(b); //Mary works for Jerry
            c.AddSubordinate(d); //Bob works for Jerry
            d.AddSubordinate(f); //Jimmy works for Bob

            //..... shows his level and asks everyone else to do the same
            string s;
            for (int i = 0; i < namesup.Length; i++)
            {
                s = Convert.ToString(namesup[i] + "," + levelsup[i]);
                if (lbworker.SelectedItem.Equals(s))
                {
                    if (i == 0)
                    {
                        if (b is IEmployee)
                            (b as IEmployee).ShowLevel(lbshowworkers);
                    }
                    if (i == 1)
                    {
                        if (c is IEmployee)
                            (c as IEmployee).ShowLevel(lbshowworkers);
                    }
                    if (i == 2)
                    {
                        if (d is IEmployee)
                            (d as IEmployee).ShowLevel(lbshowworkers);
                    }
                }
            }

            lbshowworkers.Items.Add("________________");
        }

        private void btnclearall_Click(object sender, EventArgs e)
        {
            lborder.Items.Clear();
        }

        }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace krgt
{
    public class Facade
    {

        Beverage chicken = new Chicken();
        Beverage beef = new Beef();
        Beverage fish = new Fish();
        Beverage fried = new Fried();
        Beverage sodawater = new SodaWater();
        Beverage tea = new Tea();
        Beverage cake = new Cake();
        Beverage pie = new Pie();

        public double ChickenMenu(double sum)
        {
            sum = chicken.cost() + fried.cost() + sodawater.cost();
            return sum;
        }

        public double BeefMenu(double sum)
        {
            sum = beef.cost() + fried.cost() + sodawater.cost();
            return sum;
        }

        public double FishMenu(double sum)
        {
            sum = fish.cost() + fried.cost() + sodawater.cost();
            return sum;
        }

        public double SweetCakeMenu(double sum)
        {
            sum = cake.cost() + tea.cost();
            return sum;
        }

        public double SweetPieMenu(double sum)
        {
            sum = pie.cost() + tea.cost();
            return sum;
        }


    }
}

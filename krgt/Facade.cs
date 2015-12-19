using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace krgt
{
    public class Facade
    {

        Food chicken = new Chicken();
        Food beef = new Beef();
        Food fish = new Fish();
        Food fried = new Fried();
        Food sodawater = new SodaWater();
        Food tea = new Tea();
        Food cake = new Cake();
        Food pie = new Pie();

        public double ChickenMenu(double sum)
        {
            sum = chicken.cost() + fried.cost() + sodawater.cost();
            sum -= (sum * 0.1);
            return sum;
        }

        public double BeefMenu(double sum)
        {
            sum = beef.cost() + fried.cost() + sodawater.cost();
            sum -= (sum * 0.1);
            return sum;
        }

        public double FishMenu(double sum)
        {
            sum = fish.cost() + fried.cost() + sodawater.cost();
            sum -= (sum * 0.1);
            return sum ;
        }

        public double SweetCakeMenu(double sum)
        {
            sum = cake.cost() + tea.cost();
            sum -= (sum * 0.15);
            return sum ;
        }

        public double SweetPieMenu(double sum)
        {
            sum = pie.cost() + tea.cost();
            sum -= (sum * 0.15);
            return sum ;
        }


    }
}

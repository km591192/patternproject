using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace krgt
{
    public abstract class Beverage
    {
        public String description = "Unknown";

        public abstract double cost();
    }



    

    //Sandwich
    public class Chicken : Beverage
    {
        public override double cost()
        { return 3.5; }
    }
    public class Cheesburger : Beverage
    {
        public override double cost()
        { return 3; }
    }
    public class Gamburger : Beverage
    {
        public override double cost()
        { return 3; }
    }
    public class Beef : Beverage
    {
        public override double cost()
        { return 4; }
    }
    public class Fish : Beverage
    {
        public override double cost()
        { return 4.5; }
    }

    //Salat

    //Drink
    public class SodaWater : Beverage
    {
        public override double cost()
        { return 1.5; }
    }

    public class Water : Beverage
    {
        public override double cost()
        { return 1; }
    }

    public class Tea : Beverage
    {
        public override double cost()
        { return 2; }
    }
    public class Coffee : Beverage
    {
        public override double cost()
        { return 2; }
    }

    public class Honey : Beverage
    {
        Beverage beverage;

        public Honey(Beverage beverage)
        { this.beverage = beverage; }

        public override double cost()
        { return 0.5 + beverage.cost(); }
    }

    public class Lemon : Beverage
    {
        Beverage beverage;

        public Lemon(Beverage beverage)
        { this.beverage = beverage; }

        public override double cost()
        { return 0.5 + beverage.cost(); }
    }

    public class Syrop : Beverage
    {
        Beverage beverage;

        public Syrop(Beverage beverage)
        { this.beverage = beverage; }

        public override double cost()
        { return 1 + beverage.cost(); }
    }

    
}

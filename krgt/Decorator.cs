using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace krgt
{

    public abstract class Food
    {
        public String description = "x";

        public abstract double cost();

        public String getDescription()
        { return description; }
    }


    public abstract class Decorator : Food
    {
        public  abstract String getDescription();
    }

    //Desert 
    public class IceCream : Food
    {
        public IceCream()
        { description = "IceCream"; }

        public override double cost()
        { return 1.5; }
    }
    public class Pie : Food
    {
        public Pie()
        { description = "Pie"; }

        public override double cost()
        { return 1.5; }
    }
    public class Cake : Food
    {
        public Cake()
        { description = "Cake"; }

        public override double cost()
        { return 1.5; }
    }

    public class IceCreamwithsauce : Decorator
    {
        Food food;

        public IceCreamwithsauce(Food food)
        { this.food = food; }


        public override String getDescription()
        { return food.getDescription() + " wtih sauce"; }

        public override double cost()
        { return 0.8 + food.cost(); }
    }
    public class Cakewithsauce : Decorator
    {
        Food food;

        public Cakewithsauce(Food food)
        { this.food = food; }

        public override String getDescription()
        { return food.getDescription() + "with sauce"; }

        public override double cost()
        { return 0.5 + food.cost(); }
    }

    //Potato
    public class Fried : Food
    {
        public Fried()
        { description = "Fried potato"; }

        public override double cost()
        { return 2.5; }
    }

    public class Friedwithsauce : Decorator
    {
       Food food;

       public Friedwithsauce(Food food)
        { this.food = food; }


        public override String getDescription()
        { return food.getDescription() + "with sauce"; }

        public override double cost()
        { return 0.5 + food.cost(); }
    }


    //Sandwich
    public class Chicken : Food
    {
        public Chicken()
        { description = "Chicken"; }

        public override double cost()
        { return 3.5; }
    }
    public class Cheesburger : Food
    {
        public Cheesburger()
        { description = "Cheesburger"; }

        public override double cost()
        { return 3; }
    }
    public class Gamburger : Food
    {
         public Gamburger()
        { description = "Gamburger"; }

        public override double cost()
        { return 3; }
    }
    public class Beef : Food
    {
         public Beef()
        { description = "Beef"; }

        public override double cost()
        { return 4; }
    }
    public class Fish : Food
    {
         public Fish()
        { description = "Fish"; }

        public override double cost()
        { return 4.5; }
    }

    //Salat
    public class ChickenSalat : Food
    {
         public ChickenSalat()
        { description = "Chicken salat"; }

        public override double cost()
        { return 5; }
    }

    public class ChickenSalatwithsauce : Decorator
    {
        Food food;

        public ChickenSalatwithsauce(Food food)
        { this.food = food; }

        public override String getDescription()
        { return food.getDescription() + "with sauce"; }

        public override double cost()
        { return 1.5 + food.cost(); }
    }
    public class BeefSalat : Food
    {

         public BeefSalat()
        { description = "Beef salat"; }

        public override double cost()
        { return 5.5; }
    }

    public class BeefSalatwithsauce : Decorator
    {
        Food food;

        public BeefSalatwithsauce(Food food)
        { this.food = food; }

        public override String getDescription()
        { return  food.getDescription() + "with sauce"; }

        public override double cost()
        { return 0.5 + food.cost(); }
    }
    public class FishSalat : Food
    {
         public FishSalat()
        { description = "Fish salat"; }

        public override double cost()
        { return 4.5; }
    }

    public class FishSalatwithsauce : Decorator
    {
        Food food;

        public FishSalatwithsauce(Food food)
        { this.food = food; }

        public override String getDescription()
        { return food.getDescription() + "with sauce"; }

        public override double cost()
        { return 0.5 + food.cost(); }
    }

    //Drink
    public class SodaWater : Food
    {
         public SodaWater()
        { description = "Pepsi/Cola/Fanta/Sprite/7up"; }

        public override double cost()
        { return 1.5; }
    }

    public class Water : Food
    {
         public Water()
        { description = "Water"; }

        public override double cost()
        { return 1; }
    }

    public class Tea : Food
    { 
        public Tea()
        { description = "Tea"; }

        public override double cost()
        { return 2; }
    }
    public class Coffee : Food
    {
         public Coffee()
        { description = "Coffee"; }

        public override double cost()
        { return 2; }
    }

    public class Honey : Decorator
    {
        Food food;

        public Honey(Food food)
        { this.food = food; }

        public override String getDescription()
        { return food.getDescription() + "with honey"; }

        public override double cost()
        { return 0.5 + food.cost(); }
    }

    public class Lemon : Decorator
    {
        Food food;

        public Lemon(Food food)
        { this.food = food; }


        public override String getDescription()
        { return food.getDescription() + "with lemon"; }

        public override double cost()
        { return 0.5 + food.cost(); }
    }

    public class Syrop : Decorator
    {
         Food food;

        public Syrop(Food food)
        { this.food = food; }


        public override String getDescription()
        { return food.getDescription() + "with syrop"; }

        public override double cost()
        { return 1 + food.cost(); }
    }
}

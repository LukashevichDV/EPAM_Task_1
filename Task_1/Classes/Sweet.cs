using Task_1.Interfaces;

namespace Task_1.Classes
{
    public class Sweet : ISweetStuff
    {
        //price of 1 gramm of sweet
        private const double SWEET_PRICE = 0.01;


        public string Name { get; protected set; }


        public int Weight { get; protected set; }


        public int Sugar { get; protected set; }


        public double Caloriety { get; protected set; }


        public Sweet(string name, int weight, int sugar, double caloriety)
        {
            Name = name;
            Weight = weight;
            Sugar = sugar;
            Caloriety = caloriety;
        }

        public virtual double GetPrice()
        {
            return SWEET_PRICE * Weight;
        }
    }


}


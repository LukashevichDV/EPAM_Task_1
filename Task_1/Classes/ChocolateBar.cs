using Task_1.Interfaces;

namespace Task_1.Classes
{
    class ChocolateBar : ISweetStuff
    {
        //price of 1 gramm of chocolate bar
        private const double CHOCOLATE_BAR_PRICE = 0.011;

        public string Name { get; protected set; }


        public int Weight { get; protected set; }


        public int Sugar { get; protected set; }


        public double Caloriety { get; protected set; }


        public ChocolateBar(string name, int weight, int sugar, double caloriety)
        {
            Name = name;
            Weight = weight;
            Sugar = sugar;
            Caloriety = caloriety;
        }

        public double getPrice()
        {
            return CHOCOLATE_BAR_PRICE * Weight;
        }
    }
}

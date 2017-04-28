using Task_1.Interfaces;

namespace Task_1.Classes
{
    class ChocolateBar : ISweetStuff
    {
        //price of 1 gramm of chocolate bar
        private const double CHOCOLATE_BAR_PRICE = 0.02;


        public string Name { get; protected set; }


        public int Weight { get; protected set; }


        public int Sugar { get; protected set; }


        public double Caloriety { get; protected set; }


        public ChocolateBar(string _name, int _weight, int _sugar, double _caloriety)
        {
            Name = _name;
            Weight = _weight;
            Sugar = _sugar;
            Caloriety = _caloriety;
        }

        public double GetPrice()
        {
            return CHOCOLATE_BAR_PRICE * Weight;
        }
    }
}

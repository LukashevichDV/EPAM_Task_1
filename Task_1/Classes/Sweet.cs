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


        public Sweet(string _name, int _weight, int _sugar, double _caloriety)
        {
            Name = _name;
            Weight = _weight;
            Sugar = _sugar;
            Caloriety = _caloriety;
        }

        public virtual double GetSweetStuffPrice()
        {
            return SWEET_PRICE * Weight;
        }
    }
}


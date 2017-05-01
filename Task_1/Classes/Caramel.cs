using Task_1.Interfaces;

namespace Task_1.Classes
{

    public class Caramel : ISweetStuff
    {
        //price of 1 gramm of caramel 
        private const double CARAMEL_PRICE = 0.005;


        public string Name { get; protected set; }


        public int Weight { get; protected set; }


        public int Sugar { get; protected set; }


        public double Caloriety { get; protected set; }


        public virtual double GetSweetStuffPrice()
        {
            return CARAMEL_PRICE * Weight;
        }


        public Caramel(string _name, int _weight, int _sugar, double _caloriety)
        {
            Name = _name;
            Weight = _weight;
            Sugar = _sugar;
            Caloriety = _caloriety;
        }
    }
}

using Task_1.Interfaces;

namespace Task_1.Classes
{
    class ChocolateBar : ISweetStuff
    {
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
    }
}

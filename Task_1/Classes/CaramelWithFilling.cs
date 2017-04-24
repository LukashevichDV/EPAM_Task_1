namespace Task_1.Classes
{

    public enum TypeCaramelFilling { Strawberry, Banana, Mint }


    public class CaramelWithFilling : Caramel
    {
        //price of 1 gramm of caramel with filling
        private const double CARAMEL_WITH_FILLING_PRICE = 0.01;

        public override double GetPrice()
        {
            return CARAMEL_WITH_FILLING_PRICE * Weight;
        }

        public TypeCaramelFilling Type;


        public CaramelWithFilling(string name, int weight, int sugar, double caloriety, TypeCaramelFilling type)
            : base(name, weight, sugar, caloriety)
        {
            this.Type = type;
        }
    }
}

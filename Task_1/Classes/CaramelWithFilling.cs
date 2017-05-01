namespace Task_1.Classes
{

    public enum TypeCaramelFilling { Strawberry, Banana, Mint }


    public class CaramelWithFilling : Caramel
    {
        //price of 1 gramm of caramel with filling
        private const double CARAMEL_WITH_FILLING_PRICE = 0.01;


        public override double GetSweetStuffPrice()
        {
            return CARAMEL_WITH_FILLING_PRICE * Weight;
        }

        public TypeCaramelFilling Type;


        public CaramelWithFilling(string _name, int _weight, int _sugar, double _caloriety, TypeCaramelFilling _type)
            : base(_name, _weight, _sugar, _caloriety)
        {
            Type = _type;
        }
    }
}

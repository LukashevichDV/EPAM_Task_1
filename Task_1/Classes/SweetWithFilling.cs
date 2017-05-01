namespace Task_1.Classes
{
    public enum TypeSweetFilling { Toffy, Nut, IrishCream }

    class SweetWithFilling : Sweet
    {
        //price of 1 gramm of sweet with filling
        private const double SWEET_WITH_FILLING_PRICE = 0.02;


        public TypeSweetFilling Type;


        public override double GetSweetStuffPrice()
        {
            return SWEET_WITH_FILLING_PRICE * Weight;
        }


        public SweetWithFilling(string _name, int _weight, int _sugar, double _caloriety, TypeSweetFilling _type)
            : base(_name, _weight, _sugar, _caloriety)
        {
            Type = _type;
        }
    }
}

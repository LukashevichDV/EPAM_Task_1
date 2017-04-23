﻿namespace Task_1.Classes
{
    public enum TypeSweetFilling { Toffy, Nut, IrishCream }

    class SweetWithFilling : Sweet
    {
        //price of 1 gramm of sweet with filling
        private const double SWEET_WITH_FILLING_PRICE = 0.012;

        public TypeSweetFilling Type;

        public override double getPrice()
        {
            return SWEET_WITH_FILLING_PRICE * Weight;
        }

        public SweetWithFilling(string name, int weight, int sugar, double caloriety, TypeSweetFilling type)
            : base(name, weight, sugar, caloriety)
        {
            this.Type = type;
        }
    }
}

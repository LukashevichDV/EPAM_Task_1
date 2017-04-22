namespace Task_1.Classes
{
    public enum TypeSweetFilling { Toffy, Nut, IrishCream }

    class SweetWithFilling : Sweet
    {
        public TypeSweetFilling Type;

        public SweetWithFilling(string name, int weight, int sugar, double caloriety, TypeSweetFilling type)
            : base(name, weight, sugar, caloriety)
        {
            this.Type = type;
        }
    }
}

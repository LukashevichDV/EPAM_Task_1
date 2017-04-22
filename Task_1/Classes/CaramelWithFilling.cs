using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_1.Classes
{
    public enum TypeCaramelFilling { Strawberry, Banana, Mint }

    public class CaramelWithFilling : Caramel
    {
        
        public TypeCaramelFilling Type;

        public CaramelWithFilling(string name, int weight, int sugar, double caloriety, TypeCaramelFilling type) 
            : base(name, weight, sugar, caloriety)
        {
            this.Type = type;
        }
    }
}

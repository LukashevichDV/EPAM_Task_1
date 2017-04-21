using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_1.Classes
{
    public class CaramelWithFilling : Caramel
    {
        public CaramelWithFilling(string name, int weight, int sugar, double caloriety) 
            : base(name, weight, sugar, caloriety)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interfaces;

namespace Task_1.Classes
{
    public class Caramel : ISweetStuff
    {
        
        public string Name
        {
            get;
            protected set;
        }
              

        public int Weight
        {
            get;
            protected set;
        }


        public int Sugar
        {
            get;
            protected set;
        }


        public double Caloriety
        {
            get;
            protected set;
        }

        public Caramel(string name, int weight, int sugar, double caloriety)
        {
            Name = name;
            Weight = weight;
            Sugar = sugar;
            Caloriety = caloriety;

        }

    }
}

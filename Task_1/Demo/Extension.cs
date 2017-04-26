using System;
using System.Linq;
using Task_1.Interfaces;

namespace Task_1.Demo
{
    public static class Extensions
    {
        public static void ShowItems(this IGift gift)
        {
            Console.WriteLine("Set of sweets in gift: ");
            foreach (var i in gift.Items)
            {
                Console.WriteLine("name: {0}, weight: {1}, sugar: {2}, caloriety: {3}"
                    , i.Name, i.Weight, i.Sugar, i.Caloriety);

            }

        }

        public static void ShowPrice(this IGift gift)
        {
            double sum = gift.Items.Sum(x => x.GetPrice());
            double y = sum;
            int z = (int)y;
            decimal b = Math.Round((((decimal)y - z) * 100), 1);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Price of a gift is:");
            Console.WriteLine("{0} dollar(s)  {1} cent(s)", z, b);
        }

        public static void ShowSweetStuffBySugar(this IGift gift)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Set of sweets beetwen min= {0} and max= {1} sugar ", 20, 110);
            foreach (var items in gift.FindSweetStuffBySugar(20, 110))
            {
                Console.WriteLine("Sweet: {0}, Sugar: {1}", items.Name, items.Sugar);
            }
        }

    }
}

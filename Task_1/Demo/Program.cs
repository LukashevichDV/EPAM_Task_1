using System;
using Task_1.Classes;
using Task_1.Demo;

namespace Task_1
{
    public class Program
    {

        static void Main(string[] args)
        {

            Gift g1 = new Gift();

            Caramel c1 = new Caramel("Chupa-chups", 150, 50, 75);
            CaramelWithFilling c2 = new CaramelWithFilling("Roshen", 20, 30, 65, TypeCaramelFilling.Banana);
            Sweet s1 = new Sweet("Choco-lapki", 15, 10, 20);
            SweetWithFilling s2 = new SweetWithFilling("Yarche", 130, 50, 100, TypeSweetFilling.Nut);

            g1.Add(c1);
            g1.Add(c2);
            g1.Add(s1);
            g1.Add(s2);

            g1.Sort();
            g1.ShowItems();
            g1.ShowPrice();
            g1.ShowSweetStuffBySugar();

            Console.ReadLine();

            
        }

    }
}

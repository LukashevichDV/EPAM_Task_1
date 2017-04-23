using System;
using Task_1.Classes;

namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Gift g1 = new Gift();

            Caramel c1 = new Caramel("Chupa-chups", 15, 50, 75);
            CaramelWithFilling c2 = new CaramelWithFilling("fewf0", 15, 50, 75,TypeCaramelFilling.Banana);

            Console.WriteLine( c1.getPrice());
            Console.WriteLine(c2.getPrice());
      
            Console.ReadLine();

            

            
        }

    }
}

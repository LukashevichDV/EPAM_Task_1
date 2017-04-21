using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Classes;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Caramel c1 = new Caramel("mars", 50, 100, 150);
            Console.WriteLine(String.Format("Caloriety = {0}" ,c1.Caloriety));
            Console.ReadLine();
        
            
        }
    }
}

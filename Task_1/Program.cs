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

            g1.Items.Add(c1);
            g1.sort();


            Console.WriteLine("Набор конфет: ");
            foreach (var i in g1.Items)
            {
                Console.WriteLine("Название конфеты: {0}, Вес конфеты: {1}, Сахар: {2}, Калории: {3},"
                    , i.Name, i.Weight, i.Sugar, i.Caloriety);
            }
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interfaces;

namespace Task_1.Demo
{
    public static class Extensions
    {
        public static void ShowItems(this IGift gift)
        {
            Console.WriteLine("Набор конфет: ");
            foreach (var i in gift.Items)
            {
                Console.WriteLine("Название конфеты: {0}, Вес конфеты: {1}, Сахар: {2}, Калории: {3},"
                    , i.Name, i.Weight, i.Sugar, i.Caloriety);

            }

        }
    }
}

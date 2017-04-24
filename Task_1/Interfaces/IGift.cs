using System.Collections.Generic;

namespace Task_1.Interfaces
{
    public interface IGift
    {
        ICollection<ISweetStuff> Items { get; }
        ICollection<ISweetStuff> FindSweetStuffBySugar(int min, int max);
        string Name { get; }
        double Weight { get; }
        void Sort();
        double GetPrice();
        string GetInfo();





    }
}

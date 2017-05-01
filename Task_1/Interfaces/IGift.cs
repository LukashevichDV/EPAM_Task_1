using System.Collections.Generic;

namespace Task_1.Interfaces
{
    public interface IGift
    {
        ICollection<ISweetStuff> Items { get; }
        ICollection<ISweetStuff> FindSweetStuffBySugar(int min, int max);
        string Name { get; }
        double GetWeight();
        void SortByWeight();
        double GetGiftPrice();
    }
}

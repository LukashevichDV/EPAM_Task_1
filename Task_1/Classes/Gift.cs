using System;
using System.Collections.Generic;
using System.Linq;
using Task_1.Interfaces;

namespace Task_1.Classes
{
    public class Gift : IGift

    {
        public ICollection<ISweetStuff> Items { get; private set; }


        public void Add(ISweetStuff stuff)
        {
            Items.Add(stuff);
        }


        public void Remove(ISweetStuff stuff)
        {
            Items.Remove(stuff);
        }


        public Gift()
        {
            Items = new List<ISweetStuff>();
        }


        public string Name { get; protected set; }


        public double Weight
        {
            get
            {
                if (Items != null)
                {
                    return Items.Sum(x => x.Weight);
                }
                else
                {
                    throw new InvalidOperationException("Container in Gift cannot be null");
                }
            }
        }


        public ICollection<ISweetStuff> FindSweetStuffBySugar(int min, int max)
        {
            if (Items != null)
            {
                return Items.Where(x => (x.Sugar >= min) && (x.Sugar <= max)).ToList();
            }
            else
            {
                throw new InvalidOperationException("Container in Gift cannot be null");
            }
        }


        public void SortByWeight()
        {
            var temp = Items.OrderBy(x => x.Weight).ToList();
            Items.Clear();
            foreach (var item in temp)
            {
                Items.Add(item);
            }
        }


        public double GetPrice()
        {

            if (Items != null)
            {
                return Items.Sum(x => x.GetPrice());
            }
            else
            {
                throw new InvalidOperationException("Container in Gift cannot be null");
            }
        }
    }
}

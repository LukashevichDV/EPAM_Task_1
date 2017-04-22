using System;
using System.Collections.Generic;
using System.Linq;
using Task_1.Interfaces;

namespace Task_1.Classes
{
    public class Gift : IGift

    {

        public string Name { get; protected set; }


        public ICollection<ISweetStuff> Items { get; private set; }


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

        public void Add(ISweetStuff stuff)
        {
            Items.Add(stuff);
        }

        public void sort()
        {
            var temp = Items.OrderBy(x => x.Weight).ToList();
            Items.Clear();
            foreach (var item in temp)
            {
                Items.Add(item);
            }
        }


        public void price()
        {
            throw new NotImplementedException();
        }


        public Gift()
        {
            Items = new List<ISweetStuff>();
        }


    }
}

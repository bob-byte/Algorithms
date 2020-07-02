using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class AlgorithmsBase<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();

        protected void Swop(Int32 positionA, Int32 positionB)
        {
            if(positionA < Items.Count && positionB < Items.Count)
            {
                T temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }

        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}

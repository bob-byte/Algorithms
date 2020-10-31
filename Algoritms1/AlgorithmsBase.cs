using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class AlgorithmsBase<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();
        public Int32 CompareCount { get; protected set; } = 0;
        public Int32 SwopCount { get; protected set; } = 0;

        protected void Swop(Int32 positionA, Int32 positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                T temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;

                SwopCount++;
            }
        }

        protected virtual void RealizeSort()
        {
            Items.Sort();
        }

        public TimeSpan Sort()
        {
            DateTime start = DateTime.Now;
            RealizeSort();
            DateTime stop = DateTime.Now;
            return stop.Subtract(start);
        }
    }
}

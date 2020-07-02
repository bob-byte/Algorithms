using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class BubbleSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        public override void Sort()
        {
            Boolean isSwop;
            for (int i = Items.Count - 1; i >= 0; i--)
            {
                isSwop = false;
                for (int j = 0; j < i; j++)
                {
                    if(Items[j].CompareTo(Items[j + 1]) == 1)
                    {
                        Swop(j, j + 1);
                        isSwop = true;
                    }
                }
                if(!isSwop)
                {
                    return;
                }
            }
        }
    }
}
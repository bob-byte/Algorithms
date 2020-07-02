using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class CocktailSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        public override void Sort()
        {
            Boolean isSwop;
            for (Int32 i = Items.Count - 1, k = 0; i > (Items.Count / 2); i--, k++)
            {
                isSwop = false;
                for (Int32 j = 0; j < i; j++)
                {
                    if (Items[j].CompareTo(Items[j + 1]) == 1)
                    {
                        Swop(j, j + 1);
                        isSwop = true;
                    }
                }
                for (Int32 j = i - 1; j > k; j--)
                {
                    if (Items[j - 1].CompareTo(Items[j]) == 1)
                    {
                        Swop(j, j - 1);
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
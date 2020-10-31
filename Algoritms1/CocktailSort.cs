using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class CocktailSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        protected override void RealizeSort()
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
                if (!isSwop)
                {
                    return;
                }
                for (Int32 j = i - 1; j > k; j--)
                {
                    if (Items[j - 1].CompareTo(Items[j]) == 1)
                    {
                        Swop(j, j - 1);
                    }
                }
            }
        }
    }
}

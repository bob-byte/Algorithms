using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class BubbleSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        protected override void RealizeSort()
        {
            Boolean isSwop;
            for (int i = Items.Count - 1; i >= 0; i--)
            {
                isSwop = false;
                for (int j = 0; j < i; j++)
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
            }
        }
    }
}

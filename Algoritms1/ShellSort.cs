using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class ShellSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        protected override void RealizeSort()
        {           
            for (Int32 i = Items.Count / 2; i > 0; i >>= 1)
            {
                for (int j = 0; j + i < Items.Count; j++)
                {
                    if(Items[j].CompareTo(Items[j + i]) == 1)
                    {
                        Swop(j, j + i);
                    }
                }
            }

            for (int i = 1; i < Items.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (Items[j - 1].CompareTo(Items[j]) == 1)
                    {
                        Swop(j - 1, j);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}

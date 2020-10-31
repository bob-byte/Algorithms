using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class InsertSort<T> : AlgorithmsBase<T> where T: IComparable
    {
        protected override void RealizeSort()
        {
            for (int i = 1; i < Items.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if(Items[j - 1].CompareTo(Items[j]) == 1)
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

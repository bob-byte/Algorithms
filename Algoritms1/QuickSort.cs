using System;

namespace Algoritms
{
    public class QuickSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        protected override void RealizeSort()
        {
            Qsort(0, Items.Count - 1);
        }

        private void Qsort(Int32 left, Int32 right)
        {
            if(left >= right)
            {
                return;
            }

            Int32 pivot = Sorting(left, right);

            Qsort(left, pivot - 1);
            Qsort(pivot + 1, right);
        }

        private Int32 Sorting(Int32 left, Int32 right)
        {
            Int32 marker = left;
            for (; left <= right; left++)
            {
                if(Items[left].CompareTo(Items[right]) == -1)
                {
                    Swop(marker++, left);
                }
            }

            Swop(marker, right);
            return marker;
        }
    }
}

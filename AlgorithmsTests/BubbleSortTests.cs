using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            BubbleSort<Int32> bubble = new BubbleSort<Int32>();

            Random rnd = new Random();
            List<Int32> list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(rnd.Next(0, 100));
            }
            bubble.Items.AddRange(list);
            list.Sort();

            bubble.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(list[i], bubble.Items[i]);
            }
        }
    }
}
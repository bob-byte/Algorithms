using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Tests
{
    [TestClass()]
    public class SortTests
    {
        static List<Int32> list;
        static Int32[] sorted;

        [DataTestMethod()]
        public void AInitialize()
        {
            Random rnd = new Random();
            list = new List<Int32>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(0, 10));
            }

            sorted = list.OrderBy(x => x).ToArray();
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            List<Int32> list = new List<Int32>();

            list.AddRange(SortTests.list);

            list.Sort();

            for (int i = 0; i < sorted.Length; i++)
            {
                Assert.AreEqual(sorted[i], list[i]);
            }
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            BubbleSort<Int32> bubble = new BubbleSort<Int32>();

            bubble.Items.AddRange(list);

            bubble.Sort();

            for (int i = 0; i < sorted.Length; i++)
            {
                Assert.AreEqual(sorted[i], bubble.Items[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            CocktailSort<Int32> cocktail = new CocktailSort<Int32>();

            cocktail.Items.AddRange(list);

            cocktail.Sort();

            for (int i = 0; i < sorted.Length; i++)
            {
                Assert.AreEqual(sorted[i], cocktail.Items[i]);
            }

        }

        [TestMethod()]
        public void InsertSortTest()
        {
            InsertSort<Int32> insert = new InsertSort<Int32>();

            insert.Items.AddRange(list);

            insert.Sort();

            for (int i = 0; i < sorted.Length; i++)
            {
                Assert.AreEqual(sorted[i], insert.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            ShellSort<Int32> shell = new ShellSort<Int32>();

            shell.Items.AddRange(list);

            shell.Sort();

            for (int i = 0; i < sorted.Length; i++)
            {
                Assert.AreEqual(sorted[i], shell.Items[i]);
            }

           // sorted.Clear();
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            QuickSort<Int32> quick = new QuickSort<Int32>();

            quick.Items.AddRange(list);

            quick.Sort();

            for (int i = 0; i < sorted.Length; i++)
            {
                Assert.AreEqual(sorted[i], quick.Items[i]);
            }

            // sorted.Clear();
        }
    }
}
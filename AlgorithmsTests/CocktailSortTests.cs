using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests
{
    [TestClass()]
    public class CocktailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            CocktailSort<Int32> cocktail = new CocktailSort<Int32>();

            Random rnd = new Random();
            List<Int32> list = new List<Int32>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(rnd.Next(0, 100));
            }
            cocktail.Items.AddRange(list);
            list.Sort();

            cocktail.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(list[i], cocktail.Items[i]);
            }
        }
    }
}
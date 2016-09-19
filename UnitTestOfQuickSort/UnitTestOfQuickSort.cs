using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace UnitTestOfQuickSort
{
    [TestClass]
    public class UnitTestOfQuickSort
    {
        [TestMethod]
        public void TestSorting()
        {
            int[] actual = { 1, 10, 5, 4, 8 };
            QuickSortAlgorithm<int> sorter = new QuickSortAlgorithm<int>();
            sorter.Sorting(actual, 0, actual.Length - 1);
            int[] expected = { 1, 4, 5, 8, 10 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrWithSameNumbers()
        {
            int[] actual = { 5, 5, 5, 5, 5, 5 };
            int[] expected = { 5, 5, 5, 5, 5, 5 };
            QuickSortAlgorithm<int> sorter = new QuickSortAlgorithm<int>();
            sorter.Sorting(actual, 0, actual.Length - 1);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAlreadySortedArr()
        {
            int[] actual = { 1, 4, 5, 8, 10 };
            int[] expected = { 1, 4, 5, 8, 10 };
            QuickSortAlgorithm<int> sorter = new QuickSortAlgorithm<int>();
            sorter.Sorting(actual, 0, actual.Length - 1);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

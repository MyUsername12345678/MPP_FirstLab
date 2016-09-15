using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        int Partition<T>(T[] arrayToSort, int indexOfFirstElement, int indexOfLastElement) where T : IComparable<T>
        {
            int i = indexOfFirstElement;
            for (int j = indexOfFirstElement; j <= indexOfLastElement; j++)
            {
                if (arrayToSort[j].CompareTo(arrayToSort[indexOfLastElement]) <= 0)
                {
                    T temp = arrayToSort[i];
                    arrayToSort[i] = arrayToSort[j];
                    arrayToSort[j] = temp;
                    i++;
                }
            }
            return i - 1;
        }

        void QuickSort<T>(T[] arrayToSort, int indexOfFirstElement, int indexOfLastElement) where T : IComparable<T>
        {
            if (indexOfFirstElement >= indexOfLastElement) return;
            int c = Partition(arrayToSort, indexOfFirstElement, indexOfLastElement);
            QuickSort(arrayToSort, indexOfFirstElement, c - 1);
            QuickSort(arrayToSort, c + 1, indexOfLastElement);
        }

    }
}

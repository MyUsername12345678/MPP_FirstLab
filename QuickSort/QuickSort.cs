using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int countOfElements = 10;
            int[] arrayToSort = RandomNumbersArray(countOfElements);
            Console.WriteLine(OutputString(arrayToSort));
            int indexOfFirstElement = 0, indexOfLastElement = countOfElements - 1;
            QuickSortAlgorithm<int>(arrayToSort, indexOfFirstElement, indexOfLastElement);
            Console.WriteLine(OutputString(arrayToSort));
            Console.Read();
        }

        static string OutputString(int[] arrayToSort)
        {
            return string.Join(",", arrayToSort);
        }

        static int[] RandomNumbersArray(int countOfElements)
        {
            int[] resultArray = new int[countOfElements];
            Random randomInt = new Random();
            for (int i = 0; i < countOfElements; i++)
            {
                resultArray[i] = randomInt.Next(-1000, 1000);
            }
            return resultArray;
        }

        static int Partition<T>(T[] arrayToSort, int indexOfFirstElement, int indexOfLastElement) where T : IComparable<T>
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

        static void QuickSortAlgorithm<T>(T[] arrayToSort, int indexOfFirstElement, int indexOfLastElement) where T : IComparable<T>
        {
            if (indexOfFirstElement >= indexOfLastElement) return;
            int c = Partition(arrayToSort, indexOfFirstElement, indexOfLastElement);
            QuickSortAlgorithm(arrayToSort, indexOfFirstElement, c - 1);
            QuickSortAlgorithm(arrayToSort, c + 1, indexOfLastElement);
        }

    }
}

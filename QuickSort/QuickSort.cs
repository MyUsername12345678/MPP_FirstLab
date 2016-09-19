using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSortProgram
    {
        static void Main(string[] args)
        {
            int countOfElements = 5;
            int[] arrayToSort = RandomNumbersArray(countOfElements);
            Console.WriteLine(OutputString(arrayToSort));
            int indexOfFirstElement = 0, indexOfLastElement = countOfElements - 1;
            QuickSortAlgorithm<int> sorter = new QuickSortAlgorithm<int>();
            sorter.Sorting(arrayToSort, indexOfFirstElement, indexOfLastElement);
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

    }

    public class QuickSortAlgorithm<T> where T : IComparable
    {

        private int Partition(T[] arrayToSort, int indexOfFirstElement, int indexOfLastElement)
        {
            int i = indexOfFirstElement;
            for (int j = indexOfFirstElement; j <= indexOfLastElement; j++)
            {
                if (arrayToSort[j].CompareTo(arrayToSort[indexOfLastElement]) <= 0)
                {
                    if (i != j)
                    {
                        T temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[j];
                        arrayToSort[j] = temp;
                    }
                    i++;

                }
            }
            return i - 1;
        }

        public void Sorting(T[] arrayToSort, int indexOfFirstElement, int indexOfLastElement)
        {
            if (indexOfFirstElement >= indexOfLastElement) return;
            int c = Partition(arrayToSort, indexOfFirstElement, indexOfLastElement);
            Sorting(arrayToSort, indexOfFirstElement, c - 1);
            Sorting(arrayToSort, c + 1, indexOfLastElement);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Randomize
{
    static class GenericMethods
    {
        public static void Print<T>(this IEnumerable<T> collectionToPrint)
        {
            Print(collectionToPrint, a => a.ToString());
        }

        public static void Print<T>(this IEnumerable<T> collectionToPrint, Func<T, string> convertItemToString)
        {
            foreach (var item in collectionToPrint)
            {
                Console.WriteLine(convertItemToString(item));
            }
        }

        public static void SortGenericArray<T>(this List<T> anyArr, Func<T, T, bool> lessThan)
        {
            for (int i = 0; i < anyArr.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < anyArr.Count; j++)
                    if (lessThan(anyArr[j], anyArr[minIndex]))
                        minIndex = j;
                T tmp = anyArr[i];
                anyArr[i] = anyArr[minIndex];
                anyArr[minIndex] = tmp;
            }
        }

        public static void Randomize<T>(this T[] items)
        {
            Random rand = new Random();

            // For each spot in the array, pick
            // a random item to swap into that spot.
            for (int i = 0; i < items.Length - 1; i++)
            {
                int j = rand.Next(i, items.Length);
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }
    }
}

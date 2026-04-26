using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{


    static int BinarySearch(int[] array, int searchedValue, int first, int last)
    {
        //межі зійшлись
        if (first > last)
        {
            //елемент не знайдено
            return -1;
        }

        //середній індекс підмасиву
        var middle = (first + last) / 2;
        //значення посередині масиву
        var middleValue = array[middle];

        if (middleValue == searchedValue)
        {
            return middle;
        }
        else
        {
            if (middleValue > searchedValue)
            {
                //рекурсивний виклик пошуку для лівого підмасиву
                return BinarySearch(array, searchedValue, first, middle - 1);
            }
            else
            {
                //рекурсивний виклик пошуку для правого підмасиву
                return BinarySearch(array, searchedValue, middle + 1, last);
            }
        }
    }

    static int IndexOfMin(int[] array, int n)
    {
        int result = n;
        for (var i = n; i < array.Length; ++i)
        {
            if (array[i] < array[result])
            {
                result = i;
            }
        }

        return result;
    }

    //метод для обміну елементів
    static void Swap(ref int x, ref int y)
    {
        var t = x;
        x = y;
        y = t;
    }

    //сортування вибором
    static int[] SelectionSort(int[] array, int currentIndex = 0)
    {
        if (currentIndex == array.Length)
            return array;

        var index = IndexOfMin(array, currentIndex);
        if (index != currentIndex)
        {
            Swap(ref array[index], ref array[currentIndex]);
        }


        return SelectionSort(array, currentIndex + 1);


    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;


        int k = 2;
        int targetNumber;
        double n = 0.6 * k + 20;
        int[] m = new int[(int)Math.Round(n)];
        Random r = new Random();

        for (int i = 0; i < m.Length; i++)
        {
            m[i] = r.Next(10, 101);
        }

        Console.WriteLine("Початковий масив: ");

        for (int i = 0; i < m.Length; i++)
        {
            Console.Write(m[i] + " ");
        }

        SelectionSort(m);

        Console.WriteLine("Відсортований масив: ");

        for (int i = 0; i < m.Length; i++)
        {
            Console.Write(m[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Введіть значення елемента, який ми шукаємо: ");
        targetNumber = Convert.ToInt32(Console.ReadLine());

        var searchResult = BinarySearch(m, targetNumber, 0, m.Length - 1);
        if (searchResult < 0)
        {
            Console.WriteLine("Елемент зі значенням {0} не знайдено", targetNumber);
        }
        else
        {
            Console.WriteLine("Елемент знайдено. Індекс елементу зі значенням {0} рівний {1}", targetNumber, searchResult);
        }


    }
}
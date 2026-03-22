using System;
using System.Text;



class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Random r = new Random();
        int N; // кількість чисел у колекції

        Console.Write("Скільки буде чисел: ");
        N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" **************************** Завдання №1 ****************************");
        // **************************** ЗАВДАННЯ № 1 ****************************
        List<int> task_1 = new List<int>();

        for (int i = 0; i < N; i++)
        {
            task_1.Add(r.Next(-5, 6)); // треба саме до 5 :)
        }

        Console.WriteLine("Колекція до видалення негативних чисел: ");

        foreach (int i in task_1)
        {
            Console.Write(i + " ");
        }

        for (int i = task_1.Count - 1; i >= 0; i--)
        {
            if (task_1[i] < 0) task_1.RemoveAt(i);
        }

        Console.WriteLine();
        Console.WriteLine("Колекція після видалення негативних чисел: ");

        foreach (int i in task_1)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        Console.WriteLine(" **************************** Завдання №2 ****************************");
        // **************************** ЗАВДАННЯ №2 ****************************

        List<int> task_2 = new List<int>();
        Console.Write("Скільки буде чисел: ");
        N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            task_2.Add(r.Next(-5, 51));
        }

        Console.WriteLine("Колекція: " + string.Join(" ", task_2));

        int lastOddIndex = -1;

        for (int i = task_2.Count - 1; i >= 0; i--)
        {
            if (task_2[i] % 2 != 0)
            {
                lastOddIndex = i;
                break; // Знайшли останнє (з кінця воно перше), зупиняємось
            }
        }

        if (lastOddIndex != -1)
        {
            task_2.Insert(lastOddIndex, -1);
            Console.WriteLine("Після вставки: " + string.Join(" ", task_2));
        }
        else
        {
            Console.WriteLine("Непарних чисел не знайдено.");
        }

        Console.WriteLine(" **************************** Завдання №3 ****************************");
        // **************************** ЗАВДАННЯ №3 ****************************

        List<int> task_3a = new List<int>();
        List<int> task_3b = new List<int>();
        List<int> result = new List<int>();

        Console.Write("Скільки буде чисел у першій колекції з пари: ");
        N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            task_3a.Add(r.Next(1, 11));
        }

        Console.Write("Скільки буде чисел у дургій колекції з пари: ");
        N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            task_3b.Add(r.Next(1, 11));
        }

        Console.WriteLine("Колекція №1: " + string.Join(" ", task_3a));
        Console.WriteLine("Колекція №2: " + string.Join(" ", task_3b));

        for (int i = 0; i < Math.Max(task_3a.Count, task_3b.Count); i++)
        {
            if (task_3a.Count > i && task_3b.Count > i)
            {
                result.Add(task_3a[i] + task_3b[i]);
            }

            if (task_3a.Count > i && task_3b.Count <= i)
            {
                result.Add(task_3a[i]);
            }

            if (task_3a.Count <= i && task_3b.Count > i)
            {
                result.Add(task_3b[i]);
            }

        }

        Console.WriteLine("Результат: " + string.Join(" ", result));

    }

}
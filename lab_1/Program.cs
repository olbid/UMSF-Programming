using System;
using System.Text;



class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;


        Console.WriteLine(" **************************** Завдання №1 ****************************");
        // **************************** ЗАВДАННЯ № 1 ****************************
        int sumOfThePositiveElemets = 0;
        int k = 0; // кількість позитивних елементів
        int[,] A = new int[5, 6];

        // Заповнення масиву

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[i, j] = Random.Shared.Next(-100, 100);
            }
        }


        // Виведення масиву

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("{0, 5}", A[i, j]);

            }
            Console.WriteLine();
        }

        // Обчислення суми
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    k++;
                    sumOfThePositiveElemets += A[i, j];
                }
            }
        }

        if (k > 0)
        {
            double average = (double)sumOfThePositiveElemets / k;
            Console.WriteLine("Середнє арифметичне: " + Math.Round(average, 2));
        }
        else
        {
            Console.WriteLine("Позитивних елементів у масиві немає, лише негатив :(");
        }


        Console.WriteLine(" **************************** Завдання №2 ****************************");
        // **************************** ЗАВДАННЯ №2 ****************************

        int[,] B = new int[4, 4];
        int[,] C = new int[4, 4];
        int[] X = new int[4]; // вектор X для матриці B
        int[] Y = new int[4]; // вектор Y для матриці C
        int[] R = new int[4]; // вектор R = X + Y


        // Заповнення масиву

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[i, j] = Random.Shared.Next(-100, 100);
                C[i, j] = Random.Shared.Next(-100, 100);
            }
        }

        // Виведення масиву B
        Console.WriteLine("Масив B: ");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("{0, 5}", B[i, j]);

            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Виведення масиву C
        Console.WriteLine("Масив C: ");
        for (int i = 0; i < C.GetLength(0); i++)
        {
            for (int j = 0; j < C.GetLength(1); j++)
            {
                Console.Write("{0, 5}", C[i, j]);

            }
            Console.WriteLine();
        }

        // Мінімальні значення
        int indexOfMinB = 0;

        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (B[i, i] < B[indexOfMinB, indexOfMinB])
            {
                indexOfMinB = i;
            }
            else
            {
                continue;
            }

        }

        int indexOfMinC = 0;

        for (int i = 0; i < C.GetLength(0); i++)
        {
            if (C[i, i] < C[indexOfMinC, indexOfMinC])
            {
                indexOfMinC = i;
            }
            else
            {
                continue;
            }

        }


        // Заповнення векторів X та Y
        for (int i = 0; i < B.GetLength(1); i++)
        {
            X[i] = B[indexOfMinB, i];
        }

        for (int i = 0; i < C.GetLength(1); i++)
        {
            Y[i] = C[indexOfMinC, i];
        }

        // Виведення векторів X та Y
        Console.WriteLine("Вектор X: ");
        for (int i = 0; i < X.Length; i++)
        {
            Console.Write("{0, 5}", X[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Вектор Y: ");
        for (int i = 0; i < Y.Length; i++)
        {
            Console.Write("{0, 5}", Y[i]);
        }

        // Заповнюємо вектор R

        for (int i = 0; i < 4; i++)
        {
            R[i] = X[i] + Y[i];
        }

        // Виведення вектора R

        Console.WriteLine();
        Console.WriteLine("Вектор R: ");
        for (int i = 0; i < R.Length; i++)
        {
            Console.Write("{0, 5}", R[i]);
        }






    }
}
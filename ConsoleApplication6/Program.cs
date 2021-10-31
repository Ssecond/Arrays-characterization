using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int x = 0;
        static int z = 0;

        static int[] InsertationSort(int[] Mass)
        {
            int[] El = new int[Mass.Length];
            for (int x = 0; x < Mass.Length; x++)
            {
                int y = x;
                while (y > 0 && El[y - 1] > Mass[x])
                {
                    El[y] = El[y - 1];
                    y--;
                }
                El[y] = Mass[x];
            }
            return El;
        }


        static void Main(string[] args)
        {
            int c = 0;
            float g = 0;
            int k = 0;
            int f = 0;
            int p = 0;

            int[] a1 = { 4, 2, 3, 5, 2 };  // Массив имеет одну пару чисел.
            int[] a2 = { 4, 4, 1, 1, 5 };  // Массив имеет две пары чисел.
            int[] a3 = { 5, 4, 1, 3, 2 };  // Массив имеет полные числа.
            int[] a4 = { 1, 5, 1, 5, 1 };  // Массив имеет вариант 3х2
            int[] a5 = { 1, 1, 1, 1, 1 };  // Массив имеет недопустимый массив

                // a1
                for (int t = 0; t < a1.Length; t++)
                {

                    for (int u = t + 1; u < a1.Length; u++)
                        if (a1[t] == a1[u])
                        {
                            p++;
                        }
                    if (p == 1)
                    {
                        Console.WriteLine("Массив имеет одну пару чисел");
                        break;
                    }

                }

            // a2
            for (int i = 0; i < a2.Length; i++)
            {
                InsertationSort(a2);
                for (int o = i + 1; o < a2.Length; o++)
                {
                    if (a2[i] == a2[o])
                    {
                        c++;
                    }
                }
            }
            if (c == 2)
            {
                Console.WriteLine("Массив имеет две пары чисел");
            }
            // a3
            for (int x = 0; x < a3.Length; x++)
            {
                if (a3[x] != g)
                {
                    Console.WriteLine("Массив имеет полные числа");
                    break;
                }
            }

            // a4
            for (int x = 0; x < a4.Length; x++)
            {
                for (int i = x + 1; i < a4.Length; i++)
                {
                    if (a4[x] > a4[i])
                    {
                        k = a4[x];
                        a4[x] = a4[i];
                        a4[i] = k;

                    }

                }

            }

            for (int y = 0; y < a4.Length; y++)
            {
                if (a4.Length == 5)
                {
                    if (a4[2] < a4[3] || a4[1] < a4[2])
                    {
                        Console.WriteLine("Массив имеет вариант 3х2");
                        break;
                    }
                }

            }

            // a5
            for (int q = 0; q < a5.Length; q++)
            {
                if (q + 1 < a5.Length)
                {
                    if (a5[q] == a5[q + 1])
                    {
                        f++;
                    }
                }
            }

            if (f == a5.Length - 1)
            {
                Console.WriteLine("Массив имеет недопустимый массив");
            }

            Console.ReadLine();
        }
        // Вводится массив и выводится в консоль надпись с подходящими вариантами.


    }
}

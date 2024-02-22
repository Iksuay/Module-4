/*
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_4
{
    internal class Application_4_3_17
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int num;

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                    Console.Write(arr[i, k] + " ");

                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for(int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i,j] > arr[i,k])
                        {
                            num = arr[i,k];
                            arr[i,k] = arr[i,j];
                            arr[i,j] = num;
                        }
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                    Console.Write(arr[i, k] + " ");

                Console.WriteLine();
            }

        }
    }
}
*/
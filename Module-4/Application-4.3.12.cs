/*
using System;

namespace Module_4
{
    internal class Application_4_3_12
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int a;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                }
            }

            foreach (var b in arr)
            {
                Console.Write(b);
            }
        }
    }
}
*/
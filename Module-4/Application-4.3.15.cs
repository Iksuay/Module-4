using System;

namespace Module_4
{
    internal class Application_4_3_15
    {
        static void Main(string[] args)
        {
            int[] arr = new int []{ -5, 6, 9, 1, 2, -3 };
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    num++;
                }
            }

            Console.WriteLine($"Количество положительных чисел: {num}");

        }
    }
}

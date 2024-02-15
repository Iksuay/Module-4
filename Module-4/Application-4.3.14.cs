using System;

namespace Module_4
{
    internal class Application_4_3_14
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var a in array)
            {
                foreach (var item in a)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}

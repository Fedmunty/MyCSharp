using System;

namespace Tutorial
{
    class MyArrays
    {
        public static string[] NewArray(uint x)
        {
            string[] array = new string[x];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                    array[i] = Console.ReadLine();
            }
            return array;
        }
        public static string[,] NewArray(uint x, uint y)
        {
            string[,] array = new string[x,y];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Console.ReadLine();
                }
            }
            return array;
        }
        
        public static void ReadArray(string[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + "\t");
            }
        }
        public static void ReadArray(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void ReadArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void ReadArray(double[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + "\t");
            }
        }
        public static void ReadArray(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + "\t");
            }
        }
        public static void ReadArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void FindeMin(int[,] array)
        {
            int min;

            min = array[0,0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            Console.WriteLine("Минимальный элемент массива: " + min);
        }
    }
}

using System;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] tab2 = { { 7, 8, 9 }, { 10, 11, 12 } };
            int[,] tab3 = new int[2, 3];

            Console.WriteLine("Wyświetlanie tablicy A");
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    Console.Write("{0,3}", tab1[i, j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine("Wyświetlanie tablicy B");
            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    Console.Write("{0,3}", tab2[i, j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine("Wyświetlanie tablicy C");
            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    Console.Write("{0,3}", tab3[i,j] = tab2[i, j] + tab1[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}

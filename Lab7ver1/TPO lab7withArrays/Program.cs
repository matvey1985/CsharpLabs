using System;

namespace TPO_lab7withArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ColumnSwaper swaper = new ColumnSwaper();
            int[,] inputArray = new int[6, 9];
            Random rnd = new Random();
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    inputArray[i, j] = rnd.Next(-99, 99);
                }
            }

            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    Console.Write(inputArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            swaper.swapColumns(inputArray);
            Console.WriteLine("\n");
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    Console.Write(inputArray[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
       
    }
}

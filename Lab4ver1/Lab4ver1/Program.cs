using System;

namespace Lab4ver1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Swapper change = new Swapper();
            int[] array = { 1, 35, 185, 4, 250, 82 };
            (int, int, int[]) result = change.SwapMaxMax(array);
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);
            for (int i = 0; i < result.Item3.Length; i++)
            {
                Console.WriteLine(result.Item3[i].ToString());
            }
            Console.ReadLine();
        }
    }
}

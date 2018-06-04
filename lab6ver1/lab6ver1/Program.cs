using System;
using System.Collections.Generic;

namespace lab6ver1
{
    class Program
    {
        static void Main(string[] args)
        {
            Remover remover = new Remover();
            List<int> randomList = new List<int>() { 1, 2, 3,12, 16, 8, 24, 10, 18, 4 };
            remover.removeSomeElements(randomList);
            foreach(int x in randomList)
            {
                Console.WriteLine(x.ToString());
            }
            Console.ReadLine();

        }
    }
}

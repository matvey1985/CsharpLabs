using System;

namespace Lab2ver1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Counter CountA = new Counter();
            Console.WriteLine("Введите предложение для подсчета букв !");
            String buffer = Console.ReadLine();
            Console.WriteLine(CountA.CountSymbolsA(buffer));
            Console.ReadLine();
        }
    }
}

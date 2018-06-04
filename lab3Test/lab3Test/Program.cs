using System;

namespace lab3Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangingNumbers Chered = new ChangingNumbers();
            int[] massiv= { 1, 2, 3, 4, 5, -65 };

            if (Chered.CheckChange(massiv)==-1) {
                Console.WriteLine(0); }
            else {
               Console.WriteLine("Числа не чередуются начиная с элемента номер " + (Chered.CheckChange(massiv))); }
            Console.ReadLine();
        }
    }
}

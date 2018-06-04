using System;
using System.Collections.Generic;

namespace lab5ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Attacher attacher = new Attacher();
            List<int> numbers = new List<int>() {-12, -3, -4, 5, 3, 4, 5, -12, -4, -5, 6, 5, 4 };
            attacher.AttachNewElements(numbers);

            foreach(int x in numbers)
            {
                Console.WriteLine(x.ToString());
            }
            Console.ReadLine();
        }
    }
}

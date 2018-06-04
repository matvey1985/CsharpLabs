using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5ver2
{
    class Attacher
    {
        public List<int> AttachNewElements(List<int> array)
        {
            int maximum = array.Max();
            int minimum = array.Min();
            int difference = maximum - minimum;
            for (int i = 0; i < array.Count; i++)
            {
                if ((array[i] % 2 == 0) && (array[i] < 0))
                {
                    array.Insert(i + 1, difference);
                    i++;
                }
            }
            return array;
        }
    }
}

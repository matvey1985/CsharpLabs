using System;
using System.Collections.Generic;
using System.Text;

namespace lab6ver1
{
    public class Remover
    {
        public List<int> removeSomeElements(List<int> array)
        {
            int firstElement = array[0];
            int lastElement = array[array.Count-1];
            int moduloRest;
            int difference = lastElement - firstElement;
           
            for(int i=array.Count-1;i>=0;i--)
            {
                moduloRest = array[i] % difference;
                if (moduloRest==0)
                {
                    array.RemoveAt(i);
                }
            }
            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8withLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ColumnSwaper swaper = new ColumnSwaper();
            List<List<int>> newArray = new List<List<int>>();
            newArray.Add(new List<int> { 2, 3, -3, -4, 5, 6, 7, 8, -10, -2 });
            newArray.Add(new List<int> { 2, 3, -3, -4, 5, 6, 7, 8, -10, -2 });
            newArray.Add(new List<int> { 2, 3, -6, -4, 5, 6, 7, 16, -10, -2 });
            newArray.Add(new List<int> { 2, 3, -17, -4, 5, 25, 7, 8, -10, -2 });

            swaper.swapColums(newArray);
            var max = newArray.Count;
        }
    }
}

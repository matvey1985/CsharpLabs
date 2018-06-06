using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9WithArrays
{
    class ColumnSorter
    {
        public int[,] sortColumns(int[,] array)
        {
            int max=0;
            int indexOfColumnWithMax = 0;
            int[] bufferarray = new int[array.GetLength(0)];
            for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                 if (array[i, j] > max)
                    {
                        max = array[i, j];
                        indexOfColumnWithMax = j;
                    }
                }
            }
            Console.WriteLine(indexOfColumnWithMax);

            for (int i = 0; i < bufferarray.Length; i++)
            {
                bufferarray[i] = array[i, indexOfColumnWithMax];
                Console.Write(bufferarray[i]);
            }
            Array.Sort(bufferarray);
            int[,] clone = (int[,])array.Clone();

            for(int k = 0; k < bufferarray.Length; k++)
            {
                for (int j =0;j<clone.GetLength(0);j++)
                {
                    if (clone[j, indexOfColumnWithMax] == bufferarray[k])
                    {
                        for(int l=0;l<array.GetLength(1);l++)
                        {
                            array[k, l] = clone[j, l];
                        }
                    }
                }
            }
            return array;
        }

    }
}

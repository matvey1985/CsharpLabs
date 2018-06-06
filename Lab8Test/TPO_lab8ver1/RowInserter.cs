using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO_lab8ver1
{
    class RowInserter
    {
        public int[,] insertRowWithMax(int[,] array)
        {
            int positiveMax = 0, numberOfRowsWithNegativeElements = 0, indexOfRowWithMax=0,m=0,n=0,k=0;
            for (int i = 0; i <array.GetLength(0); i++)
            {
                for (int j = 0; j <array.GetLength(1); j++)
                {
                    if (array[i, j] > positiveMax) { positiveMax = array[i, j];indexOfRowWithMax = i; }
                }
            }
            Console.WriteLine("Индекс строки с максимальным положительным = " +indexOfRowWithMax);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) ; j++)
                {
                    if ((array[i, j]%2!=0)&&(array[i,j]<0)) { numberOfRowsWithNegativeElements=numberOfRowsWithNegativeElements+1; break; }
                }
            }
            Console.WriteLine("Количество строк с нечетным негативным элементом =" + numberOfRowsWithNegativeElements);
            int[,] bufferArray = new int[array.GetLength(0)+numberOfRowsWithNegativeElements,array.GetLength(1)];
            for (int i=0;i<=array.GetLength(0)-1;i++)
            {
                m = i + n;
                for (int j=0;j<array.GetLength(1);j++)
                {
                    if ((array[i, j] % 2 != 0) && (array[i, j] < 0)){ k = 1;break; }
                    else { k = 0; }
                }
                if (k == 0)
                {
                    n = n + 0;
                    for (int l=0;l<array.GetLength(1);l++)
                    {
                        bufferArray[m, l] = array[i,l];
                    }
                }
                else if (k == 1)
                {
                    for (int l = 0; l < array.GetLength(1) ; l++)
                    {
                        bufferArray[m, l] = array[i, l];
                        bufferArray[m+1, l] = array[indexOfRowWithMax, l];
                    }
                    n = n + 1;
                }
            }

            for (int i = 0; i < bufferArray.GetLength(0); i++)
            {
                for (int j = 0; j < bufferArray.GetLength(1); j++)
                {
                    Console.Write(bufferArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return bufferArray;
        }
    }
}

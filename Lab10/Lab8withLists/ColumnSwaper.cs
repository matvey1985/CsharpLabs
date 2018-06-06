using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8withLists
{
    class ColumnSwaper
    {
        public List<List<int>> swapColums(List<List<int>> array)
        {
            List<List<int>> bufferArray = new List<List<int>>();
            List<int> bufferListWithMax = new List<int>();
            bufferArray = new List<List<int>>(array);
            int max = 0;
            int IndexOfRowWithMax = 0;
            int n = 0;
            for(int i = 0; i < bufferArray.Count;i++)
            {
                for (int j=0;j<bufferArray[i].Count;j++)
                {
                    if (bufferArray[i][j] > max) {
                        max = bufferArray[i][j];
                        IndexOfRowWithMax = i;
                    }
                }
                 n = bufferArray.Count;
            }
            bufferListWithMax = new List<int>(bufferArray[IndexOfRowWithMax]);
           
            for (int i = bufferArray.Count-1; i >=0; i--)
            {
                for (int j = 0; j < bufferArray[i].Count; j++)
                {
                    if ((bufferArray[i][j]%2!=0)&&(bufferArray[i][j]<0))
                    {                      
                        bufferArray.Insert(i+1, bufferListWithMax);
                        break;
                    }
                }
            }
            for (int i = 0; i < bufferArray.Count; i++)
            {
                for (int j = 0; j < bufferArray[i].Count; j++)
                {
                    Console.Write(" " + bufferArray[i][j]);
                }
                Console.WriteLine(" ");
                
            }
            Console.WriteLine(" " + IndexOfRowWithMax);
            Console.ReadKey();
            return bufferArray;

        }
    }
}

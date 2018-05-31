using System;

namespace Lab4ver1
{
    public class Swapper
    {
        public (int, int, int[]) SwapMaxMax(int[] array)
        {
            int max = array[0];
            int maxindex = 0;
            for (int k = 0; k < array.Length; k++)
            {
                if (max < array[k])
                {
                    max = array[k];
                    maxindex = k;
                }
            }
            int nearMax1 = 0;
            int nearMax2 = 1;
            int summoftwo1 = max - (array[0] + array[1]);
            for (int i = 0; i < array.Length; i++)
            {
                if (i == maxindex) continue;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (j == maxindex) continue;
                    int sumoftwobuffer = max - (array[i] + array[j]);
                    if (sumoftwobuffer < summoftwo1)
                    {
                        nearMax1 = i;
                        nearMax2 = j;
                        summoftwo1 = sumoftwobuffer;
                    }
                }
            }
            int buffer = array[nearMax1];
            array[nearMax1] = array[nearMax2];
            array[nearMax2] = buffer;

            return (array[nearMax1], array[nearMax2], array);
        }
    }
}

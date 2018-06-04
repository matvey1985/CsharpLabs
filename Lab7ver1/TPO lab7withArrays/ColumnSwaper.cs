namespace TPO_lab7withArrays
{
    class ColumnSwaper
    {
        public int[,] swapColumns(int[,] array)
        {
            int counter = 0;
            int indexOfSecondOdd = 0;
            int indexOfLastNegative = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[0, i] % 2 == 0) { counter = counter + 1; }
                if (counter == 2) { indexOfSecondOdd = i; break; }
            }
            
            for (int i = array.GetLength(1) - 1; i >= 0; i--)
            {
                if (array[0, i] < 0) { indexOfLastNegative = i; break; }
            }
            int[,] clone = (int[,])array.Clone();
            for (int j = 0; j < clone.GetLength(0); j++)
            {
                array[j, indexOfSecondOdd] = clone[j, indexOfLastNegative];
                array[j, indexOfLastNegative] = clone[j, indexOfSecondOdd];
            }
            return array;
        }
    }
}

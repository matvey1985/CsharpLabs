namespace lab3Test
{
    class ChangingNumbers
    {
        public int CheckChange(int[] array) {
            for (int i = 1; i < array.Length; i++) {
                int previousModula = array[i - 1] % 2;
                int currentModula = array[i] % 2;
                if ((previousModula == currentModula)|(previousModula == -currentModula))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

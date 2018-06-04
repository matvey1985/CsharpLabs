using System.Linq;

namespace Lab2ver1
{
    class Counter
    {
        public int CountSymbolsA(string text)
        {
            int internalcount = 0;
            char[] separators = new char[] { ' ', '.' };
            string[] words = text.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
            bool[] rightACount = new bool[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                internalcount = 0;
                internalcount = words[i].ToCharArray().Count(c=>((c=='a')|(c=='а')));
                if (internalcount == 3)
                {
                    rightACount[i] = true;
                }
                else { rightACount[i] = false; }
            }
            return rightACount.Count(e => e==true);
        }
    }
}

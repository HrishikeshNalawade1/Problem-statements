using System;

namespace program2
{
    class Program2
    {
        static int countOccurrences(string str,
                           string word)
        {
            // split the string by spaces
            string[] a = str.Split(' ');

            // search for pattern in string
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {

                // if match found increase count
                if (word.Equals(a[i]))
                    count++;
            }

            return count;
        }
        static void Main(string[] args)
        {
            string str = "How do you do ";
            string word = "do";
            Console.Write(countOccurrences(str, word));

        }
    }
}

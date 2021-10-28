using System;
namespace LongestSubstring.Classes
{
    public class StringHelper
    {
        public StringHelper()
        {
        }

        public int GetLongestSequenceLength(string word)
        {
            if (word == null)
            {
                return 0;
            }

            var longest = 0;
            var start = 0;
            string current;
            int position;
            int i;

            while (start < word.Length)
            {
                current = "";
                for (i = start; i < word.Length; i++)
                {
                    position = current.IndexOf(word[i]);
                    if (position < 0)
                    {
                        current += word[i];
                    }
                    else
                    {
                        if (current.Length > longest)
                        {
                            longest = current.Length;
                        }
                        start += position + 1;
                        break;
                    }
                }
                if (i == word.Length)
                {
                    if (current.Length > longest)
                    {
                        longest = current.Length;
                    }
                    break;
                }
            }


            return longest;
        }
    }
}

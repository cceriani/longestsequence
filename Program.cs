using System;
using LongestSubstring.Classes;

namespace LongestSubstring
{
    class Program
    {


        static void Main(string[] args)
        {
            /* TASK: Given a string, find the length of the longest substring without repeating characters.
             * 
             * Test cases:
             * Input "abcabcdbb"      - Expected output: 4 ("abcd")
             * Input "pwwkew"         - Expected output: 3 ("wke")
             * Input "abcabcdbbacdef" - Expected output: 6 ("bacdef")
             * Input "abcdefghi"      - Expected output: 9 ("abcdefghi")
             * Input "abcdefghd"      - Expected output: 8 ("abcdefgh")
             * 
             */

            var word = "abcabcdbb";
            var result = new StringHelper().GetLongestSequenceLength(word);

            Console.WriteLine($"Longest sequence: {result}");
        }
    }
}

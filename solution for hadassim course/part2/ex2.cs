using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution_for_hadassim_course.part2
{
    internal class ex2
    {
        static bool IsSortedPalindrome(string word)
        {
            int i, len = word.Length;
            for (i = 0; i < len / 2; i++)
            {
                if (word[i] == word[len - i - 1] && word[i] < word[i + 1])
                    continue;
                return false;
            }
            return true;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(IsSortedPalindrome("abcba")==true?"true":"false");
        //}
    }
}

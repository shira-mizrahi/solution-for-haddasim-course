using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution_for_hadassim_course.part2
{
    internal class ex3
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
        static void Main(string[] args)
        {
            double num=0;
            List<double> list = new List<double>();
            Console.WriteLine("enter the number:");
            num = double.Parse(Console.ReadLine());
            while (num!=-1) {
                list.Add(num);
                Console.WriteLine("enter the number:");
                num=double.Parse(Console.ReadLine());
            }
            Console.WriteLine(list.Sum()/list.Count);
            List<double> positiveNums= list.Where(n=>n>0).ToList();
            Console.WriteLine("positive nums ");
            foreach(var n in positiveNums) Console.WriteLine(n+" ");
            List<double> orderedList = list.OrderBy(n => n).ToList();
            Console.WriteLine("ordered list  ");
            foreach (var n in orderedList) Console.WriteLine(n + " ");
            Console.ReadKey();

        }
    }
}

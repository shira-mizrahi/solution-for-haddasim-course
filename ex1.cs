using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution_for_hadassim_course
{
    internal class ex1
    {
        static int GetNumLength(int? num)
        {
            return num == 0 ? 0 : 1 + GetNumLength(num / 10);
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(GetNumLength(134));
        //}
    }
}

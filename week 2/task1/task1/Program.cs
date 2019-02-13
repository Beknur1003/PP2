using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program

    {
        public static bool polindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;

            while (i < j)
            {
                if (str[i] != str[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (polindrome(s))
            {
                Console.Write("Yes");
                Console.ReadKey(true);
            }
            else
            {
                Console.Write("NO");
                Console.ReadKey(true);
            }
        }
    }
}

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
            int i = 0;                              //создаем i = 0              \\
            int j = str.Length - 1;                //создаем j равный длине str -1\\
            
            while (i < j)                           //создаем цикл пока i < j\\
            {       
                if (str[i] != str[j])               //создаем условие, если буква под индексем i не равна букве под индексем j\\
                    return false;

                i++;
                j--;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();        //читаем строку \\
            if (polindrome(s))                   //создаем условие и отправляем стринг s и проверяем на полиндромность\\
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();          //читаем первую строку         \\
            int n = int.Parse(s);                  //переводим из стринга в интеджер\\

            for (int i = 0; i < n; i++)            //создаем двойной форик от 0 до n\\
            {
                for (int j = 0; j <= i; j++)       //пробегаемся от 0 до того где j <= i\\
                {
                    Console.Write("[*]");           //вписываем [*]
                }
                Console.WriteLine();                //переходим на нижнюю строку\\
            }
        }
    }
}
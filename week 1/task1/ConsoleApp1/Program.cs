using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp15
{
    class Program
    {
        static bool isPrime(int n)
        {
            if (n == 1 || n == 0) return false;        //Нахождение прайм числа
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();                //читаем первую строку                            \\
            int n = int.Parse(s);                        //конвертируем со стринга в интеджер                \\
            string k = Console.ReadLine();              //читаем вторую строку                                \\
            string[] arr = k.Split();                  //записываем в новый массив удалив пробелы между цифрами\\
            int cnt = 0;                              //начальное значение прайм чисел                          \\

            for (int i = 0; i < arr.Length; i++)         //создаем форик\\
            {
                if (isPrime(int.Parse(arr[i]))) cnt++;  //проверяем числа на прайм и если прайм, то cnt+1\\
            }
            Console.WriteLine(cnt);                     //записываем количество прайм чисел\\

            for (int i = 0; i < arr.Length; i++)         //пробегаемся от 0 до длины массива\\
            {
                if (isPrime(int.Parse(arr[i])))         //проверяем число на прайм\\
                {
                    Console.Write(arr[i]);              //записываем прайм число   \\
                    Console.Write(" ");                //ставлю пробел между числами\\
                }
            }
        }
    }
}
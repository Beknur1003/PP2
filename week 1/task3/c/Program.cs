using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp15
{
    class Program
    {
        static int[] arrMaker(string[] arr)
        {
            int cnt = -1;                                //начальное количество равно 0               \\
            int[] array = new int[arr.Length * 2];     //создаем массив в два раза больше изначального\\
            for (int i = 0; i < arr.Length; i++)      //пробегаемся с 0 до длины первого массива       \\
            {
                cnt++;
                array[cnt] = int.Parse(arr[i]);        //array[0] = 1 \\                    
                cnt++;
                array[cnt] = int.Parse(arr[i]);        //array[1] = 1 \\                          
            }
            return array;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();              //читаем первую строку                          \\
            int n = int.Parse(s);                      //переводим из стринга в интеджер                 \\
            string k = Console.ReadLine();            //читаем вторую строку                              \\
            string[] arr = k.Split();                //создаем массив и убераем все пробелы                \\
            int[] array = arrMaker(arr);            //создаем массив и кидаем старый массив в метод arrMaker\\
            for (int i = 0; i < array.Length; i++) //пробегаемся от 0 до длины нового массива                \\
            {
                Console.Write(array[i]);           //записываем значение нового массива\\
                Console.Write(' ');               //ставим пробелы между числами        \\
            }
            Console.ReadKey(true);                //чтобы быстро не пропала консоль\\
        }
    }
}
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
            int cnt = -1;
            int[] array = new int[arr.Length * 2];
            for (int i = 0; i < arr.Length; i++)
            {
                cnt++;
                array[cnt] = int.Parse(arr[i]);
                cnt++;
                array[cnt] = int.Parse(arr[i]);
            }
            return array;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            string k = Console.ReadLine();
            string[] arr = k.Split();
            int[] array = arrMaker(arr);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(' ');
            }
        }
    }
}
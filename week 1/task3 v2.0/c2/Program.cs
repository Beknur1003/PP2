using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            string k = Console.ReadLine();
            string[] arr = k.Split();

            for (int i = 0; i < arr.Length; i++)
            {
                int num = int.Parse(arr[i]);
                Console.Write(num);
                Console.Write(" ");
                Console.Write(num);
                Console.ReadKey();
            }
        }
    }
}

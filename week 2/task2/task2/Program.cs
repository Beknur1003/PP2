using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace example
{
    class Program
    {
        static bool prime(int n)
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void Main(String[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\text.txt");
            string s = sr.ReadToEnd();
            string[] arr = s.Split(' ');
            sr.Close();
            StreamWriter sw = new StreamWriter(@"C:\Users\Asus\Desktop\output.txt");
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                int num = int.Parse(arr[i]);
                if (prime(num))
                {
                    res = res + num + " ";
                }
            }
            sw.Write(res);
            sw.Close();
        }
    }
}
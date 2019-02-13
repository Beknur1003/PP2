using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace example
{
    class Program
    {
        public static void Main(String[] args)
        {
            string fileName = "test.txt";
            string path = @"C:\Users\Asus\Desktop\" + fileName;
            string path1 = @"C:\Users\Asus\Desktop\davai\" + fileName;
            StreamWriter sw = new StreamWriter(path);
            sw.Write(12345);
            sw.Close();
            File.Copy(path, path1);
            File.Delete(path);

        }
    }
}
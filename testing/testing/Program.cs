using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "text.txt";
            string path1 = @"C:\Users\Asus\Desktop\" + file;
            string path2 = @"C:\Users\Asus\Desktop\davai" + file;
            StreamWriter sw = new StreamWriter(path1);
            sw.Write("BeknurBekkaliev");
            sw.Close();
            File.Copy(path1, path2);
            File.Delete(path1);
        }
    }
}

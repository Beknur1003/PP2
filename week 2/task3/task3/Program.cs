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
        static void whitespace(int level)
        {
            for (int i = 0; i < level * 4; i++)
            {
                Console.Write(' ');
            }
        }
        static void print(string path, int level)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] fileInfos = d.GetFiles();
            DirectoryInfo[] directoryInfos = d.GetDirectories();

            foreach (FileInfo f in fileInfos)
            {
                whitespace(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo dinfo in directoryInfos)
            {
                whitespace(level);
                Console.WriteLine(dinfo.Name);
                print(dinfo.FullName, level + 1);
            }

        }

        public static void Main(String[] args)
        {
            print(@"C:\Users\Asus\Desktop\davai", 0);
        }
    }
}
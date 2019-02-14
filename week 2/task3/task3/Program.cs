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
        static void whitespace(int level)                       //создаем пустоту слева\\
        {
            for (int i = 0; i < level * 4; i++)                 //умножаем на 4, можно на любое другое число\\
            {
                Console.Write(' ');                             
            }
        }
        static void print(string path, int level)               
        {
            DirectoryInfo d = new DirectoryInfo(path);             //создаем директорию д с путем к файлу                                          \\
            FileInfo[] fileInfos = d.GetFiles();                  //создаем массив fileInfos и записываем туда файлы из директории d с путем path   \\
            DirectoryInfo[] directoryInfos = d.GetDirectories(); //создаем массив directoryInfos и записываем туда файлы из директории d с путем path\\

            foreach (FileInfo f in fileInfos)                     //для каждого файла новой переменной f в fileInfos\\
            {
                whitespace(level);                                //пустота будет равна 0, так как это файл\\
                Console.WriteLine(f.Name);                       //записываем имя файла в консоли           \\
            }
            foreach (DirectoryInfo dinfo in directoryInfos)       //для каждой директории новой переменной dinfo в directoryInfos\\
            {
                whitespace(level);                                 //первая пустота равна нулю                      \\
                Console.WriteLine(dinfo.Name);                    //записываем в консоль имя дииректории             \\
                print(dinfo.FullName, level + 2);                //level+2 чтобы 0 не умножать на 4 чтобы была пустота\\
            }

        }

        public static void Main(String[] args)
        {
            print(@"C:\Users\Asus\Desktop\davai", 0);           //в принте записываем путь к файлу и level изначально который должен быть равен 0\\
            Console.ReadKey(true);                             //чтобы быстро не закрылся, чтобы ждал любое нажатие клафиши                       \\
        }
    }
}